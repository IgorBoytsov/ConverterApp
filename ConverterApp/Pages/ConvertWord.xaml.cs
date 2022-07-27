using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;
using ConverterApp.Method;
using Microsoft.Office.Interop.Word;
//using GemBox.Document;
using Microsoft.Win32;


namespace ConverterApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для ConvertPDF_Word.xaml
    /// </summary>
    public partial class ConvertWord : System.Windows.Controls.Page
    {
        public ConvertWord()
        {
            InitializeComponent();
        }

        public void BntOpenFile_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Resources["nameFileWordToPDF"] = txbName.Text;
            Converting.WordToPDF();
        }

        private void bntConvertHTML_Click(object sender, RoutedEventArgs e)
        {
            //App.Current.Resources["nameFileWordToPDF"] = txbName.Text;
            //Converting.WordToHTML();
        }

        private void bntConvertTXT_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Resources["nameFileWordToPDF"] = txbName.Text;
            Converting.WortToTXT();
        }

        private void bntConvertEpub_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Resources["nameFileWordToPDF"] = txbName.Text;
            Converting.WordToEpub();
        }
    }
}
