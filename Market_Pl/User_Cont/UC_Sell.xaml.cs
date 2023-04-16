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
    /// Логика взаимодействия для UC_Sell.xaml
    /// </summary>
    public partial class UC_Sell : UserControl
    {
        MarketEntities _context = new MarketEntities();
        List<Sell> _material = new List<Sell>();
        List<Sell> _stocks = new List<Sell>();
        private string _FindedName;
        public UC_Sell()
        {
            InitializeComponent();
            LV_User_.ItemsSource = _context.Sells.OrderBy(Stock => Stock.Sell_id).ToList();
            this._material = _context.Sells.ToList();
        }
        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            _FindedName = SearchBox.Text;
            _material = _context.Sells.OrderBy(t => t.Sell_id).ToList();
            Updates();
        }
        public void Updates()
        {
            if (SearchBox.Text != "")
            {
                _material = _material.OrderBy(t => t.Sell_Article).Where(t => t.Sell_Article.ToLower().Contains(_FindedName)).ToList();

            }
            LV_User_.ItemsSource = _material;
        }

        public void Update_Sells()
        {
            _material = _context.Sells.ToList();
            LV_User_.ItemsSource = _material;
        }
        private void New_Siryu_Click(object sender, RoutedEventArgs e)
        {
            Sell_Add stock_Add = new Sell_Add(_context, this);
            stock_Add.ShowDialog();
        }

        private void Edit_del_Click_1(object sender, RoutedEventArgs e)
        {
            Sell_Edit_Del edit_Del_Stock = new Sell_Edit_Del(_context, sender, this);
            edit_Del_Stock.ShowDialog();
        }
    }
}
