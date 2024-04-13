﻿using Praktika1.BookStoreDataSetTableAdapters;
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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        CustomersTableAdapter Customers = new CustomersTableAdapter();
        public Page1()
        {
            InitializeComponent();
            CustomersDataGrid.ItemsSource = Customers.GetData();
        }
    }
}
