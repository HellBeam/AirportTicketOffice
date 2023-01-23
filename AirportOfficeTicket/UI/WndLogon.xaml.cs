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
using System.IO;

namespace AirportOfficeTicket
{
    /// <summary>
    /// Логика взаимодействия для Logon.xaml
    /// </summary>
    public partial class WndLogon : Window
    {
        List<string> accounts = new List<string>();       //Массив для проверки данных
        public WndLogon()
        {
            InitializeComponent();
            downloadAccounts();        //Вызов метода для загрузки аккаунтов в массив
        }
        /// <summary>
        /// Метод downloadAccounts
        /// Читает текстовый документ построчно
        /// </summary>
        private void downloadAccounts()
        {
            StreamReader stream = new StreamReader("Logon.txt");
            while (!stream.EndOfStream)
            {
                accounts.Add(stream.ReadLine());
            }
        }
        private int counter = 0;
        /// <summary>
        /// Обработчик события на кнопку
        /// Осуществляет авторизацию в системе
        /// Также ограничивает кол-во неудачных попыток
        /// </summary>
        private async void BtnLog_Click(object sender, RoutedEventArgs e)
        {
            counter++;
            if (counter == 3)
            {
                BtnLog.IsEnabled = false;
                TxtbLogin.IsEnabled = false;
                TxtbLogin.Text = "";
                Passbx.Password = "";
                TxtbPass.Text = "";
                MessageBox.Show("Вы использовали 3 попытки входа в систему" + "Через 15 секунд Вы сможете повторить попытку входа в систему",
                    "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                await Task.Run(async () =>
                {
                    await Task.Delay(15000);
                });
                counter = 0;
                TxtbLogin.IsEnabled = true;
                BtnLog.IsEnabled = true;
                return;
            }
            authorize();
        }
        /// <summary>
        /// Метод authorize
        /// Осуществляет проверку введённых данных по массиву
        /// </summary>
        private void authorize()
        {
            for (int i = 0; i < accounts.Count; i++)
            {
                if (TxtbLogin.Text == accounts[i])
                {
                    if (Passbx.Password == accounts[i+1] || TxtbPass.Text == accounts[i+1])
                    {
                        MessageBox.Show("Вы успешно вошли в систему", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                        if (accounts[i+2] == "Клиент")
                        {
                            WndHomeCust wndHomeCust = new WndHomeCust();
                            wndHomeCust.Show();
                        }
                        else if (accounts[i+2] == "Билетный кассир")
                        {
                            WndHomeMen wndHomeMen = new WndHomeMen();
                            wndHomeMen.Show();
                        }
                        Close();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Пароль введён неверно! Повторите попытку.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
            }
            MessageBox.Show("Логин введён неверно! Повторите попытку.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }
        /// <summary>
        /// Обработчик нажатия на checkbox
        /// Осуществляет управление видимостью элементов с паролем
        /// </summary>
        private void ChckbPass_Click(object sender, RoutedEventArgs e)
        {
            if (ChckbPass.IsChecked == true)
            {
                TxtbPass.Text = Passbx.Password;
                TxtbPass.Visibility = Visibility.Visible;
                Passbx.Visibility = Visibility.Hidden;
            }
            else
            {
                Passbx.Password = TxtbPass.Text;
                TxtbPass.Visibility= Visibility.Hidden;
                Passbx.Visibility= Visibility.Visible;
            }
        }
        /// <summary>
        /// Обработчик изменения содержимого textbox
        /// Осуществляет управление активностью элементов в зависимости от наличия текста в textbox
        /// </summary>
        private void TxtbLogin_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TxtbLogin.Text != "")
            {
                Passbx.IsEnabled = true;
                ChckbPass.IsEnabled = true;
            }
            else
            {
                Passbx.Password = "";
                TxtbPass.Text = "";
                ChckbPass.IsChecked = false;
                TxtbPass.Visibility = Visibility.Hidden;
                Passbx.Visibility = Visibility.Visible;
                Passbx.IsEnabled = false;
                ChckbPass.IsEnabled = false;
            }
        }
    }
}
