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
    /// Логика взаимодействия для PgAddCust.xaml
    /// </summary>
    public partial class PgAddCust : Page
    {
        public PgAddCust()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Обработчик события на кнопку
        /// Выводит окно с сообщением
        /// </summary>
        private void btnAddCust_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Функционал в разработке", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
