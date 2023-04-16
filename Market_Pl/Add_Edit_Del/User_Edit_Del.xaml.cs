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
    /// Логика взаимодействия для User_Edit_Del.xaml
    /// </summary>
    public partial class User_Edit_Del : Window
    {
        private MarketEntities _context;
        private UC_User _Main;
        private Department _product;

        public User_Edit_Del(MarketEntities marketEntities, object o, UC_User uC_User)
        {
            InitializeComponent();
            _context = marketEntities;
            _product = (o as Button).DataContext as Department;
            _Main = uC_User;
            Nomination.Text = _product.Departments_Nomination;
            Surname.Text = _product.Departments_Surname;
            Name.Text = _product.Departments_Name;
            Patronymic.Text = _product.Departments_Patronymic;
            Number.Text = _product.Departments_Number;
            Implementation.Text = _product.Departments_Implementation;
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
                _product.Departments_Nomination = Nomination.Text;
                _product.Departments_Surname = Surname.Text;
                _product.Departments_Name = Name.Text;
                _product.Departments_Patronymic = Patronymic.Text;
                _product.Departments_Number = Number.Text;
                _product.Departments_Implementation = Implementation.Text;
                _context.SaveChanges();
                _Main.Update_Dep();
                this.Close();
            }
        }

        private void Product_Del_Click(object sender, RoutedEventArgs e)
        {
            if ((MessageBox.Show("Вы уверены, что хотите удалить информацию?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
            {
                _context.Departments.Remove(_product);
                _context.SaveChanges();
                _Main.Update_Dep();
                this.Close();
            }
        }
    }
}
