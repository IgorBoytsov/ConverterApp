using ConverterApp.Pages;
using Microsoft.Win32;
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

namespace ConverterApp
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

        private void dtnConvert_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //ConvertPNG convertPNG = new ConvertPNG();
            //string NameFile = (string)App.Current.Resources["nameFileWordToPDF"];


            if (ofd.ShowDialog() == true)
            {
                string str = ofd.FileName;
                string path = System.IO.Path.GetExtension(str);
                App.Current.Resources["filePath"] = str;
                txbFileName.Text = str;

                if (path == ".docx")
                {
                    ConverterFrame.Navigate(new ConvertWord());
                }
                if (path == ".PDF")
                {
                    ConverterFrame.Navigate(new ConvertPDF());
                }
                if (path == ".png")
                {
                    img.Source = new BitmapImage(new Uri(ofd.FileName));
                    ConverterFrame.Navigate(new ConvertPNG());
                }
                if (path == ".JPG")
                {
                    ConverterFrame.Navigate(new ConvertJPG());
                }
            }
            
        }

        private void btnSetings_Click(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }
    }
}
