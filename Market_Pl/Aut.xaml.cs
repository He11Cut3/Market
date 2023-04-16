using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Market_Pl
{
    /// <summary>
    /// Логика взаимодействия для Aut.xaml
    /// </summary>
    public partial class Aut : Window
    {
        private string text = String.Empty;
        MarketEntities _context = new MarketEntities();
        public Aut()
        {
            InitializeComponent();
        }


        private void Cls_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Avt_Click(object sender, RoutedEventArgs e)
        {
            var login = Login.Text;
            var password = Password.Password;
            Market_User users = null;
            using (ApplicationContext applicationContext = new ApplicationContext())
            {
                users = (Market_User)_context.Market_User.Where(b => b.Market_User_Login == login && b.Market_User_Password == password).FirstOrDefault();
            }
            if (users != null)
            {
                MainWin knit_Main = new MainWin();
                this.Close();
                knit_Main.ShowDialog();

            }
            else
            {
                System.Windows.MessageBox.Show("Неправильный логин или пароль");
            }
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
        }
    }
}
