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

namespace WPFPractice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int cli = 0;
        public static String Clicks {
            get { return cli + ""; }
        
                
                }

       
        public MainWindow()
        {
            InitializeComponent();
            this.Title = "New Title";
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            Title = e.GetPosition(this).ToString();
        }

        public static readonly DependencyProperty clickProperty =
        DependencyProperty.Register("Clicks", typeof(string), typeof(Window), new PropertyMetadata(null));
        private void Button1Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(Clicks);
            cli++;
            
        }
    }
}
