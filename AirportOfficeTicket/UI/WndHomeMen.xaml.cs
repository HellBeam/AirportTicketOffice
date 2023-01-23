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

namespace AirportOfficeTicket
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class WndHomeMen : Window
    {
        public WndHomeMen()
        {
            InitializeComponent();
            FrmHome.Navigate(new PgHome());       //Задаётся основная страница в форме
        }
        /// <summary>
        /// Обработчик события на кнопку
        /// Открывает соответсвующую страницу в форме
        /// </summary>
        private void MiRegistr_Click(object sender, RoutedEventArgs e)
        {
            FrmHome.Navigate(new PgAddCust());
        }
        /// <summary>
        /// Обработчик события на кнопку
        /// Открывает соответсвующую страницу в форме
        /// </summary>
        private void MiReserve_Click(object sender, RoutedEventArgs e)
        {
            FrmHome.Navigate(new PgReserve());
        }
        /// <summary>
        /// Обработчик события на кнопку
        /// Открывает окно справки
        /// </summary>
        private void MiHelp_Click(object sender, RoutedEventArgs e)
        {
            WndHelp wndHelp = new WndHelp();
            wndHelp.Show();
        }
    }
}
