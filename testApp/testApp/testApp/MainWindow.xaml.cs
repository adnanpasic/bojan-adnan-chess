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

namespace testApp
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

        private void exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        int count = 0;
        private void HitMe_Click(object sender, RoutedEventArgs e)
        {

            if (count == 0)
            {
                asss.Visibility = Visibility;
                count++;
            }
            else if (count == 1)
            {
                king.Visibility = Visibility;
                count++;
            }
        }
         
        

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            asss.Visibility = System.Windows.Visibility.Hidden;
            king.Visibility = System.Windows.Visibility.Hidden;
            count = 0;
        }

        

    }
}

