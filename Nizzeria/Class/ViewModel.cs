using Nizzeria.Class.Ingredients;
using Nizzeria.Class.TypesOfPizza;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Nizzeria.Class
{
    public class ViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Pizza> Pizzas { get; set; } = new ObservableCollection<Pizza>();
        private Pizza _selectedPizza;
        public Pizza SelectedPizza
        {
            get { return _selectedPizza; }
            set
            {
                _selectedPizza = value;
                OnPropertyChanged("SelectedPizza");
            }
        }

        public ObservableCollection<string> NamePizzas { get; set; } = new ObservableCollection<string>();
        public string SelectedTypePizza { get; set; }

        public ObservableCollection<string> NameIngredients { get; set; } = new ObservableCollection<string>();
        private string _selectedTypeIngredient;
        public string SelectedTypeIngredient
        {
            get { return _selectedTypeIngredient; }
            set
            {
                _selectedTypeIngredient = value;
                OnPropertyChanged("SelectedTypeIngredient");
            }
        }

        public ViewModel()
        {
            NamePizzas.Add("American");
            NamePizzas.Add("Chicago");
            NamePizzas.Add("Italian");
            NamePizzas.Add("New York");

            NameIngredients.Add("Cheese");
            NameIngredients.Add("Chicken Fillet");
            NameIngredients.Add("Ham");
            NameIngredients.Add("Hot Pepper");
        }

        public void AddPizza()
        {
            Pizza NewPizza;

            switch (SelectedTypePizza)
            {
                case "American":
                    NewPizza = new American();
                    break;
                case "Chicago":
                    NewPizza = new Chicago();
                    break;
                case "Italian":
                    NewPizza = new Italian();
                    break;
                case "New York":
                    NewPizza = new NewYork();
                    break;
                default:
                    NewPizza = new NullPizza();
                    break;
            }

            Pizzas.Add(NewPizza);
        }

        public void AddIngredient()
        {
            switch (SelectedTypeIngredient)
            {
                case "Cheese":
                    SelectedPizza = new Cheese(SelectedPizza);
                    break;
                case "Chicken Fillet":
                    SelectedPizza = new ChickenFillet(SelectedPizza);
                    break;
                case "Ham":
                    SelectedPizza = new Ham(SelectedPizza);
                    break;
                case "Hot Pepper":
                    SelectedPizza = new HotPepper(SelectedPizza);
                    break;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
