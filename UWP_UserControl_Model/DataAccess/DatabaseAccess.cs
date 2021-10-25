using System.Collections.ObjectModel;
using UWP_UserControl_Model.DataModels;

namespace UWP_UserControl_Model.DataAccess
{
    public class DatabaseAccess
    {
        public ObservableCollection<Product> GetProducts()
        {
            var products = new ObservableCollection<Product>();

            products.Add(new Product { ID = 1, Name = "Juice", Discontinued = false });
            products.Add(new Product { ID = 2, Name = "Shoe", Discontinued = false });
            products.Add(new Product { ID = 3, Name = "Bread", Discontinued = false });
            products.Add(new Product { ID = 4, Name = "House", Discontinued = false });
            products.Add(new Product { ID = 5, Name = "Shirt", Discontinued = false });
            products.Add(new Product { ID = 6, Name = "Chair", Discontinued = true });
            products.Add(new Product { ID = 7, Name = "Phone", Discontinued = true });
            products.Add(new Product { ID = 8, Name = "Bin Bag", Discontinued = false });
            products.Add(new Product { ID = 9, Name = "Rust Bucket", Discontinued = false });
            products.Add(new Product { ID = 10, Name = "Mouse", Discontinued = true });
            products.Add(new Product { ID = 11, Name = "Paper", Discontinued = false });
            products.Add(new Product { ID = 12, Name = "AC", Discontinued = false });
            products.Add(new Product { ID = 13, Name = "Cabinet", Discontinued = true });
            products.Add(new Product { ID = 14, Name = "Meat", Discontinued = true });
            products.Add(new Product { ID = 15, Name = "Calendar", Discontinued = false });
            products.Add(new Product { ID = 16, Name = "Match Stick", Discontinued = true });
            products.Add(new Product { ID = 17, Name = "Table", Discontinued = true });
            products.Add(new Product { ID = 18, Name = "Locks", Discontinued = false });
            products.Add(new Product { ID = 19, Name = "Windows", Discontinued = false });
            products.Add(new Product { ID = 20, Name = "Doors", Discontinued = true });

            return products;
        }
    }
}
