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
    /// Interaction logic for SalesWindow.xaml
    /// </summary>
    public partial class SalesWindow : Window
    {
        public SalesWindow()
        {
            InitializeComponent();
        }

        private void logout_btn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow login = new MainWindow();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void profile_Click(object sender, RoutedEventArgs e)
        {
            ProfileWindow profile = new ProfileWindow();
            profile.Owner = this;
            profile.ShowDialog();
        }

        private void order_btn_Click(object sender, RoutedEventArgs e)
        {
            ManagerWindow mo = new ManagerWindow();
            this.Hide();
            mo.ShowDialog();
            this.Close();
        }

        private void Product_btn_Click(object sender, RoutedEventArgs e)
        {
            ProductWindow mp = new ProductWindow();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void delete_btn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
