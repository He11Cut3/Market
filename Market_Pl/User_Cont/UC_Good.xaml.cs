using Market_Pl.Add_Edit_Del;
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

namespace Market_Pl.User_Cont
{
    /// <summary>
    /// Логика взаимодействия для UC_Good.xaml
    /// </summary>
    public partial class UC_Good : UserControl
    {
        MarketEntities _context = new MarketEntities();
        List<Good> _material = new List<Good>();
        List<Good> _stocks = new List<Good>();
        private string _FindedName;
        public UC_Good()
        {
            InitializeComponent();
            LV_User_.ItemsSource = _context.Goods.OrderBy(Stock => Stock.Goods_id).ToList();
            this._material = _context.Goods.ToList();
        }
        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            _FindedName = SearchBox.Text;
            _material = _context.Goods.OrderBy(t => t.Goods_id).ToList();
            Updates();
        }
        public void Updates()
        {
            if (SearchBox.Text != "")
            {
                _material = _material.OrderBy(t => t.Goods_Name).Where(t => t.Goods_Name.ToLower().Contains(_FindedName)).ToList();

            }
            LV_User_.ItemsSource = _material;
        }

        public void Update_God()
        {
            _material = _context.Goods.ToList();
            LV_User_.ItemsSource = _material;
        }
        private void New_Siryu_Click(object sender, RoutedEventArgs e)
        {
            Goods_Add stock_Add = new Goods_Add(_context, this);
            stock_Add.ShowDialog();
        }

        private void Edit_del_Click_1(object sender, RoutedEventArgs e)
        {
            Goods_Edit_Del edit_Del_Stock = new Goods_Edit_Del(_context, sender, this);
            edit_Del_Stock.ShowDialog();
        }
    }
}
