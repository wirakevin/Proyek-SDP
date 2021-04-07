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

namespace Aplikasi_ProyekSDP
{
    /// <summary>
    /// Interaction logic for ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        public ProductWindow()
        {
            InitializeComponent();
        }

        private void order_btn_Click(object sender, RoutedEventArgs e)
        {
            ManagerWindow mo = new ManagerWindow();
            this.Hide();
            mo.ShowDialog();
            this.Close();
        }

        private void logout_btn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow login = new MainWindow();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void insert_btn_Click(object sender, RoutedEventArgs e)
        {
            InsertproductWindow ip = new InsertproductWindow();
            ip.Owner = this;
            ip.ShowDialog();
        }

        private void update_btn_Click(object sender, RoutedEventArgs e)
        {
            UpdateWindow up = new UpdateWindow();
            up.Owner = this;
            up.ShowDialog();
        }

        private void delete_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void profile_Click(object sender, RoutedEventArgs e)
        {
            ProfileWindow profile = new ProfileWindow();
            profile.Owner = this;
            profile.ShowDialog();
        }

        private void product_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sales_btn_Click(object sender, RoutedEventArgs e)
        {
            SalesWindow ms = new SalesWindow();
            this.Hide();
            ms.ShowDialog();
            this.Close();
        }
    }
}
