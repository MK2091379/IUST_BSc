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
using Microsoft.Win32;

namespace WPF
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
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            MyTabs.SelectedItem = tab2;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("C:\\Users\\MSI\\Pictures\\Screenshots\\1.png");
            image.EndInit();
            window1.image1.Source = image;
            window1.Show();
        }
    }
}
