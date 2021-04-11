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

namespace ClassWork4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private List<Car> GetCars()
        //{
        //    return new List<Car>
        //    {
        //        new Car{Model="E-200",Vendor="Mercedes",Year=2018},
        //        new Car{Model="Aveo",Vendor="Chevrolet",Year=2020},
        //        new Car{Model="M5",Vendor="BMW",Year=2000}
        //};
        //}
        public MainWindow()
        {
            InitializeComponent();
            //listbox.ItemsSource = GetCars();
            //prgbar.IsIndeterminate = false;
        }

        //private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    var item = combobox1.SelectedItem as ComboBoxItem;
        //    var stackpanel = item.Content as StackPanel;
        //    foreach(var element in stackpanel.Children)
        //    {
        //        if(element is TextBlock tb)
        //        {
        //            MessageBox.Show(tb.Text);
        //        }
        //    }
        //}

        //  /*  private void listbox*/_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //    {
        //        //var car = listbox.SelectedItem as Car;
        //        //if (car != null)
        //        //{
        //        //    modeltextbox.Text = $"Model:{car.Model}";
        //        //    vendortextbox.Text = $"Vendor:{car.Vendor}";
        //        //    yeartextbox.Text = $"Year:{ car.Year.ToString()}";
        //        //}
        //        //modeltextbox.Text = "Model;";
        //        //vendortextbox.Text = "Vendor: ";
        //        //yeartextbox.Text = "Year:";
        //        //var carObject = listbox.SelectedItems;
        //        //foreach(var item in carObject)
        //        //{
        //        //    if(item is Car car)
        //        //    {
        //        //        modeltextbox.Text += car.Model + " ";

        //        //        vendortextbox.Text += car.Vendor + " ";
        //        //        yeartextbox.Text += car.Year.ToString()+" ";
        //        //    }
        //        //}

        //    //}

        //    //private void repeatbutton1_Click(object sender, RoutedEventArgs e)
        //    //{
        //    //    if (prgbar.Value > prgbar.Minimum)
        //    //    {
        //    //        --prgbar.Value;
        //    //    }
        //    //}

        //    //private void repeatbutton2_Click(object sender, RoutedEventArgs e)
        //    //{
        //    //    if(prgbar.Value < prgbar.Maximum)
        //    //    {
        //    //        ++prgbar.Value;
        //    //    }
        //    //}

        //    //private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        //    //{
        //    //    txtblock.Text = Convert.ToInt32(slider1.Value).ToString();
        //    //    txtblock2.Text = Convert.ToInt32(slider1.Value).ToString();
        //    //}
        //}
    }
}
