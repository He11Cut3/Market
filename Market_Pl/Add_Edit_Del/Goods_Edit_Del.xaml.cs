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
    /// Логика взаимодействия для Goods_Edit_Del.xaml
    /// </summary>
    public partial class Goods_Edit_Del : Window
    {
        private MarketEntities _context;
        private UC_Good _Main;
        private Good _product;

        public Goods_Edit_Del(MarketEntities marketEntities, object o, UC_Good uC_User)
        {
            InitializeComponent();
            _context = marketEntities;
            _product = (o as Button).DataContext as Good;
            _Main = uC_User;
            Article.Text = _product.Goods_Article;
            Name.Text = _product.Goods_Name;
            Unit.Text = _product.Goods_Unit;
            Sum.Text = _product.Goods_Sum;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Product_Edit_Click(object sender, RoutedEventArgs e)
        {
            if ((MessageBox.Show("Вы уверены, что хотите изменить информацию?", "Изменение", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
            {
                _product.Goods_Article = Article.Text;
                _product.Goods_Name = Name.Text;
                _product.Goods_Unit = Unit.Text;
                _product.Goods_Sum = Sum.Text;
                _context.SaveChanges();
                _Main.Update_God();
                this.Close();
            }
        }

        private void Product_Del_Click(object sender, RoutedEventArgs e)
        {
            if ((MessageBox.Show("Вы уверены, что хотите удалить информацию?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
            {
                _context.Goods.Remove(_product);
                _context.SaveChanges();
                _Main.Update_God();
                this.Close();
            }
        }
    }
}
