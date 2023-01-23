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

namespace AirportOfficeTicket
{
    /// <summary>
    /// Логика взаимодействия для Help.xaml
    /// </summary>
    public partial class WndHelp : Window
    {
        public WndHelp()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Обработчик события на кнопку
        /// Скрывает окно справки
        /// </summary>
        private void BtnHideHelp_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }
    }
}
