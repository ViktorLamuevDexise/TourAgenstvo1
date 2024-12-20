using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TourAgenstvo
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginScreen : Page
    {
        public LoginScreen()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new ToursPage());
        }
        private bool IsValidadmin(string login, string password)
        {

            return login == "Admin" && password == "123";
        }
        private bool IsValidmanager(string login, string password)
        {
            return login == "Manager" && password == "1234";
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string login = dopUsername.Text;
            string password = dopPassword.Password;


            if (IsValidadmin(login, password))
            {
                MessageBox.Show("Добро пожаловать в систему Администратора!");
                Manager.MainFrame.Navigate(new HotelsPage());

            }
            else if (IsValidmanager(login, password))
            {
                MessageBox.Show("Добро пожаловать в систему Менеджера");
                Manager.MainFrame.Navigate(new AddEditPage(null));

            }

            else
            {
                MessageBox.Show("Неправильный пароль или логин.");
            }
        }
    }
}