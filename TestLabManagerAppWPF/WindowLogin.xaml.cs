using Microsoft.Extensions.DependencyInjection;
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
using TestLabEntity.AutoDB;
using TestLabLibrary.Repository;

namespace TestLabManagerAppWPF
{
    /// <summary>
    /// Interaction logic for WindowLogin.xaml
    /// </summary>
    public partial class WindowLogin : Window
    {
        public WindowLogin()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) DragMove();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Password;

            // validate username and password
            if (username == "" || password == "")
            {
                txtError.Text = "Username and password must not be empty!";
                return;
            }

            // validate password
            if (password.Length < 3)
            {
                txtError.Text = "Password must be at least 3 characters!";
                return;
            }

            var adminRepository = MyService.serviceProvider.GetService<IAdminRepository>();
            TlAdmin admin = adminRepository.Login(username, password);
            if (admin == null)
            {
                txtError.Text = "Username or password is incorrect!";
                return;
            }
            // show main window
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            // close login window
            this.Close();
        }
    }
}
