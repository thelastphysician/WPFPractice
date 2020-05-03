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
using System.IO;
using Microsoft.Win32;


namespace WPFPractice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      
        
       
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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The app is closing");
            this.Close();
        }

        private void BTNOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDLG = new OpenFileDialog();
            openDLG.ShowDialog();
        }

        private void BTNSaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveDLG = new SaveFileDialog();
            saveDLG.ShowDialog();
        }
    }
}
