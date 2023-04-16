using Market_Pl.User_Cont;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Market_Pl
{
    /// <summary>
    /// Логика взаимодействия для MainWin.xaml
    /// </summary>
    public partial class MainWin : Window
    {
        MarketEntities _context = new MarketEntities();
        public MainWin()
        {
            InitializeComponent();
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlControlBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WindowInteropHelper helper = new WindowInteropHelper(this);
            SendMessage(helper.Handle, 161, 2, 0);
        }
        private void pnlControlBar_MouseLeftButtonDown(object sender, MouseEventArgs e)
        {
            DragMove();
        }
        private void pnlControlBar_MouseEnter(object sender, MouseEventArgs e)
        {
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
                this.WindowState = WindowState.Maximized;
            else this.WindowState = WindowState.Normal;
        }


        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

            LV_Plan_Grid.Children.Clear();
            LV_Plan_Month_Grid.Children.Clear();
            LV_Plan_Week_Grid.Children.Clear();
            LV_Order.Children.Clear();
            LV_Recipe.Children.Clear();
            LV_Product.Children.Clear();


            UC_User uC_User = new UC_User();
            LV_User_Grid.Children.Add(uC_User);
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {

            LV_User_Grid.Children.Clear();
            LV_Plan_Month_Grid.Children.Clear();
            LV_Plan_Week_Grid.Children.Clear();
            LV_Plan_Grid.Children.Clear();
            LV_Recipe.Children.Clear();
            LV_Product.Children.Clear();

            UC_Good uC_Order = new UC_Good();
            LV_Order.Children.Add(uC_Order);

        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {


            LV_User_Grid.Children.Clear();
            LV_Plan_Month_Grid.Children.Clear();
            LV_Plan_Week_Grid.Children.Clear();
            LV_Plan_Grid.Children.Clear();
            LV_Recipe.Children.Clear();
            LV_Order.Children.Clear();

            UC_Sell uC_Product = new UC_Sell();
            LV_Product.Children.Add(uC_Product);
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            List<Good> God = _context.Goods.ToList();
            List<Sell> Sell = _context.Sells.ToList();

            // Определяем наименования столбцов
            string[] columnNames = new string[] { "Наименование", "Единица измерения", "Цена", "Кол-во"};
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            // Создаем новый файл Excel
            using (ExcelPackage package = new ExcelPackage())
            {
                // Добавляем лист
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Продукт");

                // Записываем наименования столбцов
                for (int i = 0; i < columnNames.Length; i++)
                {
                    worksheet.Cells[1, i + 1].Value = columnNames[i];
                }

                // Записываем данные
                for (int i = 0; i < God.Count; i++)
                {
                    worksheet.Cells[i + 2, 1].Value = God[i].Goods_Name;
                    worksheet.Cells[i + 2, 2].Value = God[i].Goods_Unit;
                    worksheet.Cells[i + 2, 3].Value = God[i].Goods_Sum;
                }

                // Сохраняем файл
                File.WriteAllBytes("Отчёт.xlsx", package.GetAsByteArray());
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = System.IO.Path.Combine(desktopPath, "Отчёт.xlsx");
                File.WriteAllBytes(filePath, package.GetAsByteArray());
            }
        }
    }
}
