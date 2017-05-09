using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Shop_Manager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            AddShopItems();
        }

        public Window Self => this;

        public ObservableCollection<ShopItem> ShopItems { get; } = new ObservableCollection<ShopItem>();
        public ObservableCollection<string> ShopItemsCategories { get; } = new ObservableCollection<string>() { "Clothes", "Electronics", "Food" };

        private void MenuItemExitOnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItemAboutClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(this, "This is a simple shop manager application.", "About", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void MenuItemAddItemsClick(object sender, RoutedEventArgs e)
        {
            AddShopItems();
        }

        private void AddShopItems()
        {
            ShopItems.Add(new ShopItem("Hat", "Lorem ipsum", 1.5, ShopItemCategory.Clothes));
            ShopItems.Add(new ShopItem("Trousers", "Good ones, I recommend", 1.5, ShopItemCategory.Clothes));
            ShopItems.Add(new ShopItem("Skirt", "You know what I mean :>", 1.5, ShopItemCategory.Clothes));
            ShopItems.Add(new ShopItem("iPhone 9", "Who would buy it?", 999999, ShopItemCategory.Electronics));
            ShopItems.Add(new ShopItem("MacBook Pro", "Half the performance, double the price", 999999, ShopItemCategory.Electronics));
            ShopItems.Add(new ShopItem("iMac", "Do you want a personal R2-D2?", 9999999, ShopItemCategory.Electronics));
            ShopItems.Add(new ShopItem("Apple", "Fresh and tasty", 1.2, ShopItemCategory.Food));
            ShopItems.Add(new ShopItem("Strawberries", "Red craziness", 2, ShopItemCategory.Food));
        }

        private void AddItemToCart(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(this, "Added item to cart!");
        }
    }
}
