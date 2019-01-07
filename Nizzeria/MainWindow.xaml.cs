using Nizzeria.Class;
using Nizzeria.Class.Ingredients;
using Nizzeria.Class.TypesOfPizza;
using System;
using System.Collections.Generic;
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

namespace Nizzeria
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel ViewModelControl;

        public MainWindow()
        {
            InitializeComponent();
            ViewModelControl = new ViewModel();
            DataContext = ViewModelControl;
        }

        private void Run_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(ViewModelControl.SelectedPizza.GetDescription() + "    " + ViewModelControl.SelectedPizza.Cost());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ViewModelControl.AddPizza();
        }

        private void Button_Click_Ing(object sender, RoutedEventArgs e)
        {
            ViewModelControl.AddIngredient();
        }

        private void Button_Click_ShowPizza(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
