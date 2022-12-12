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

namespace TabControls
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void tbControlList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //MessageBox.Show("work");
        }

        private void Expander_Expanded(object sender, RoutedEventArgs e)
        {
            var result = sbExpanded.Children.OfType<Expander>();

            foreach (var item in sbExpanded.Children)
            {
                Expander data = (Expander)item;
                
                if((Expander)sender != data)
                    data.IsExpanded = false;
                else
                    data.IsExpanded = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tbItem_2.IsEnabled = false;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            tbItem_2.IsEnabled = true;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            lbCities.Items.Add(tbxAddCity.Text);
        }

        private void lbCities_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show("test");    
        }
    }
}
