using ConverterApp.Method;
using System;
using System.Collections.Generic;
using System.Drawing;
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
using Image = System.Windows.Controls.Image;

namespace ConverterApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для ConvertPNG.xaml
    /// </summary>
    public partial class ConvertPNG : Page
    {
      
        public ConvertPNG()
        {
            InitializeComponent();

        }

        private void Convert_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Resources["nameFileWordToPDF"] = txbName.Text;
            Converting.PNGToJPG();
        }
    }

}
