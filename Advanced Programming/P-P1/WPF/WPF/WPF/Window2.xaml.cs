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
using System.Windows.Shapes;

namespace WPF
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
        void timer1_Tick(object sender , EventArgs e)
        {
            myProgress.Value += 10;
            if (myProgress.Value == 100)
            {
                timer.Stop();
                new MainWindow().ShowDialog();
                this.Close();
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }
    }
}
