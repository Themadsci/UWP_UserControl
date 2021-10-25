using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWP_UserControl_Model.DataAccess;
using UWP_UserControl_Model.DataModels;
using UWP_UserControl_Model.DataTypes;
using UWP_UserControl_ViewModel.Commands;

namespace UWP_UserControl_ViewModel.ViewModels
{
    public class MainViewModel : Notifier
    {
        private readonly DatabaseAccess db;

        public MainViewModel()
        {
            db = new DatabaseAccess();

            SetProperties();
        }

        private ObservableCollection<Product> products;
        public ObservableCollection<Product> FilteredProducts { get; set; }

        private string searchProductID;
        public string SearchProductID
        {
            get { return searchProductID; }
            set
            {
                searchProductID = value;
                OnPropertyChanged(nameof(SearchProductID));

                // filter name of each collection based on searched ID entered in bound textbox
                // ARTICLE: convert string input into int
                FilteredProducts = new ObservableCollection<Product>(products.Where(p => p.ID.ToString() == SearchProductID));
                // when search field is cleared, return full collection
                if (string.IsNullOrWhiteSpace(SearchProductID))
                {
                    FilteredProducts = products;
                }
                OnPropertyChanged(nameof(FilteredProducts));
            }
        }

        private string searchProductName;
        public string SearchProductName
        {
            get { return searchProductName; }
            set
            {
                searchProductName = value;
                OnPropertyChanged(nameof(SearchProductName));

                // filter name of each collection based on searched name entered in bound textbox
                // ARTICLE: To ingnore case, search lower cases for collection and input. Contains() method checks if string contains what is typed in
                FilteredProducts = new ObservableCollection<Product>(products.Where(p => p.Name.ToLower().Contains(SearchProductName.ToLower())));
                // when search field is cleared, return full collection
                if (string.IsNullOrWhiteSpace(SearchProductName))
                {
                    FilteredProducts = products;
                }
                OnPropertyChanged(nameof(FilteredProducts));
            }
        }

        private string searchProductDiscontinued;
        public string SearchProductDiscontinued
        {
            get { return searchProductDiscontinued; }
            set
            {
                searchProductDiscontinued = value;
                OnPropertyChanged(nameof(SearchProductDiscontinued));

                // if "All" combobox content is selected, return all products. This is default
                if (SearchProductDiscontinued.Equals("All"))
                {
                    FilteredProducts = products;
                }
                else
                {
                    // else search accordingly. First convert string to bool
                    bool discontinued = bool.Parse(SearchProductDiscontinued);

                    FilteredProducts = new ObservableCollection<Product>(products.Where(p => p.Discontinued == discontinued));
                }
                OnPropertyChanged(nameof(FilteredProducts));
            }
        }

        public List<string> SearchDiscontinuedList { get; private set; }

        public RelayCommand ClearCommand { get; private set; }
        private void ExecuteClear(object parameter)
        {
            Reset();
        }

        private void Reset()
        {
            // clear search fields which will also reset filtered products collection
            SearchProductID = "";
            SearchProductName = "";

            // set first options list as initial selected item
            SearchProductDiscontinued = SearchDiscontinuedList.FirstOrDefault();
        }

        private void SetProperties()
        {
            // initialize properties in single method
            products = db.GetProducts();
            FilteredProducts = products;

            // set command
            ClearCommand = new RelayCommand(ExecuteClear, null);

            // set discontinued list
            SearchDiscontinuedList = new List<string>() { "All", "True", "False" };

            // set first options list as initial selected item
            SearchProductDiscontinued = SearchDiscontinuedList.FirstOrDefault();
        }

    }
}
