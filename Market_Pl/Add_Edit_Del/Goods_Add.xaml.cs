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
    /// Логика взаимодействия для Goods_Add.xaml
    /// </summary>
    public partial class Goods_Add : Window
    {
        private MarketEntities _context;
        private UC_Good c_User;
        public Goods_Add(MarketEntities marketEntities, UC_Good uC_User)
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
                _context.Goods.Add(new Good()
                {
                    Goods_Article = Article.Text,
                    Goods_Name = Name.Text,
                    Goods_Unit = Unit.Text,
                    Goods_Sum = Sum.Text,
                });
                _context.SaveChanges();
                c_User.Update_God();
                this.Close();
            }
        }
    }
}
