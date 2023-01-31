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

namespace Avtoriz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_reg_Click(object sender, RoutedEventArgs e)
        {
            string login = log.Text.Trim();
            string password = pass.Password.Trim();
            string password1 = pass1.Password.Trim();
            string email = pochta.Text.ToLower();

            if (login.Length < 4)
            {
                log.Background = Brushes.Red;
                MessageBox.Show("Минимум 4 символа в логине");
            }
            else if (password.Length < 4)
            {
                pass.Background = Brushes.Red;
                MessageBox.Show("Минимум 4 символа в пароле");
            }
            else if (password1 != password)
            {
                pass1.Background = Brushes.Red;
                MessageBox.Show("Не сходятся пароли");
            }
            else if (!email.Contains("@"))
            {
                pochta.Background = Brushes.Red;
                MessageBox.Show("Не похоже на почту");
            }
            else
            { 
                MessageBox.Show("Успех");
            }
        }
    }
}
