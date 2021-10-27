using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Input;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace UWP_UserControl.UserControls
{
    public sealed partial class FilterUserControl : UserControl
    {
        public FilterUserControl()
        {
            this.InitializeComponent();
        }

        public string SearchProductID
        {
            get { return (string)GetValue(SearchProductIDProperty); }
            set { SetValue(SearchProductIDProperty, value); }
        }
        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SearchProductIDProperty =
            DependencyProperty.Register(nameof(SearchProductID), typeof(string), typeof(FilterUserControl), new PropertyMetadata(null));

        public string SearchProductName
        {
            get { return (string)GetValue(SearchProductNameProperty); }
            set { SetValue(SearchProductNameProperty, value); }
        }
        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SearchProductNameProperty =
            DependencyProperty.Register(nameof(SearchProductName), typeof(string), typeof(FilterUserControl), new PropertyMetadata(null));

        public List<string> SearchDiscontinuedList
        {
            get { return (List<string>)GetValue(SearchDiscontinuedListProperty); }
            set { SetValue(SearchDiscontinuedListProperty, value); }
        }
        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SearchDiscontinuedListProperty =
            DependencyProperty.Register(nameof(SearchDiscontinuedList), typeof(List<string>), typeof(FilterUserControl), new PropertyMetadata(null));

        public string SearchProductDiscontinued
        {
            get { return (string)GetValue(SearchProductDiscontinuedProperty); }
            set { SetValue(SearchProductDiscontinuedProperty, value); }
        }
        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SearchProductDiscontinuedProperty =
            DependencyProperty.Register(nameof(SearchProductDiscontinued), typeof(string), typeof(FilterUserControl), new PropertyMetadata(null));

        public ICommand ClearCommand
        {
            get { return (ICommand)GetValue(ClearCommandProperty); }
            set { SetValue(ClearCommandProperty, value); }
        }
        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ClearCommandProperty =
            DependencyProperty.Register(nameof(ClearCommand), typeof(ICommand), typeof(FilterUserControl), new PropertyMetadata(null));
    }
}
