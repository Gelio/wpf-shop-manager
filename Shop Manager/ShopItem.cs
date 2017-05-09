using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using Shop_Manager.Annotations;

namespace Shop_Manager
{
    public class ShopItem
    {
        private string _description;
        private string _name;
        private double _price;
        private ShopItemCategory _category;

        public string Description
        {
            get => _description;
            set { _description = value; OnPropertyChanged(nameof(Description)); }
        }

        public string Name
        {
            get => _name;
            set { _name = value; OnPropertyChanged((nameof(Name))); }
        }

        public double Price
        {
            get => _price;
            set { _price = value; OnPropertyChanged(nameof(Price)); }
        }

        public ShopItemCategory Category
        {
            get => _category;
            set { _category = value; OnPropertyChanged((nameof(Category))); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ShopItem(string name, string description, double price, ShopItemCategory category)
        {
            Description = description;
            Name = name;
            Price = price;
            Category = category;
        }

        public ShopItem()
        {
            
        }
    }
}