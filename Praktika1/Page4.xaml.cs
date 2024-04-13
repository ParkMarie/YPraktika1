using Praktika1.BookStoreDataSetTableAdapters;
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
using Praktika1.BookStoreDataSetTableAdapters;

namespace Praktika1
{
    /// <summary>
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        OrderInfoTableAdapter OrderInfo = new OrderInfoTableAdapter();
        public Page4()
        {
            InitializeComponent();
            OrderInfoDataGrid.ItemsSource = OrderInfo.GetData();
        }
    }
}
