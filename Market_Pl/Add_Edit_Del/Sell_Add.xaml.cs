using Market_Pl.User_Cont;
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

namespace Market_Pl.Add_Edit_Del
{
    /// <summary>
    /// Логика взаимодействия для Sell_Add.xaml
    /// </summary>
    public partial class Sell_Add : Window
    {
        private MarketEntities _context;
        private UC_Sell c_User;
        public Sell_Add(MarketEntities marketEntities, UC_Sell uC_User)
        {
            InitializeComponent();
            this._context = marketEntities;
            this.c_User = uC_User;
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void Dep_Click(object sender, RoutedEventArgs e)
        {
            if ((MessageBox.Show("Вы уверены, что хотите добавить информацию?", "Добавление", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
            {
                _context.Sells.Add(new Sell()
                {
                    Sell_Article = Article.Text,
                    Sell_Date = Date.Text,
                    Sell_Unit = Unit.Text,
                });
                _context.SaveChanges();
                c_User.Update_Sells();
                this.Close();
            }
        }
    }
}
