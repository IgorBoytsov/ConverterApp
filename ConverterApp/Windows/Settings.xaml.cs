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

namespace ConverterApp
{
    /// <summary>
    /// Логика взаимодействия для Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            // Изменеине настроек для ока Setting
            //if (ChekBoxArhive.IsChecked == true)
            //{

            //}

            if (comboBoxTheme.SelectedIndex == 0)
            {
                mainGrid.Background = Brushes.White;
            }
            if (comboBoxTheme.SelectedIndex == 1)
            {
                mainGrid.Background = Brushes.Black;
            }

            // Изменение настроек для 
        }
    }
}
