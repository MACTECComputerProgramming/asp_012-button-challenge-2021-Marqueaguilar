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

namespace Challeng_asp_cs_0012_marque
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (checkbox1.IsChecked == true)
            {
               
                label.Content = "pencil nice choice";
                
                
            }
            if (checkbox2.IsChecked == true)
            {

                label.Content = "pen nice u man";
            }
            if (checkbox3.IsChecked == true)
            {

                label.Content = "phone, ok zoomer";
            }

            if (checkbox4.IsChecked == true)
            {
                label.Content = "pad nice choice";
            }

        }
    }
}

