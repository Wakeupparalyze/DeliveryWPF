using DeliveryWPF.API;
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

namespace DeliveryWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string Login { get; set; }
        public PasswordBox Password { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Password = PasswordTxt;
            DataContext = this;
        }
        private async void SignIn(object sender, RoutedEventArgs e)
        {
            string password = Password.Password;
            try
            {
                var user = await Client.Instance.UserLogin(Login, password);
                Main main = new Main(user);
                main.Show();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void ForgPass(object sender, RoutedEventArgs e)
        {

        }
    }
}
