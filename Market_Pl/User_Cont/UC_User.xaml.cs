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
    /// Логика взаимодействия для UC_User.xaml
    /// </summary>
    public partial class UC_User : UserControl
    {
        MarketEntities _context = new MarketEntities();
        List<Department> _material = new List<Department>();
        List<Department> _stocks = new List<Department>();
        private string _FindedName;
        public UC_User()
        {
            InitializeComponent();
            LV_User_.ItemsSource = _context.Departments.OrderBy(Stock => Stock.Departments_id).ToList();
            this._material = _context.Departments.ToList();
        }
        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            _FindedName = SearchBox.Text;
            _material = _context.Departments.OrderBy(t => t.Departments_id).ToList();
            Updates();
        }
        public void Updates()
        {
            if (SearchBox.Text != "")
            {
                _material = _material.OrderBy(t => t.Departments_Nomination).Where(t => t.Departments_Nomination.ToLower().Contains(_FindedName)).ToList();

            }
            LV_User_.ItemsSource = _material;
        }

        public void Update_Dep()
        {
            _material = _context.Departments.ToList();
            LV_User_.ItemsSource = _material;
        }
        private void New_Siryu_Click(object sender, RoutedEventArgs e)
        {
            User_Add stock_Add = new User_Add(_context, this);
            stock_Add.ShowDialog();
        }

        private void Edit_del_Click_1(object sender, RoutedEventArgs e)
        {
            User_Edit_Del edit_Del_Stock = new User_Edit_Del(_context, sender, this);
            edit_Del_Stock.ShowDialog();
        }
    }
}
