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
    /// Interaction logic for OrderWindow.xaml
    /// </summary>
    public partial class OrderWindow : Window
    {
        public OrderWindow()
        {
            InitializeComponent();
        }

        private void pay_btn_Click(object sender, RoutedEventArgs e)
        {
            ConfirmpayWindow cp = new ConfirmpayWindow();
            cp.Owner = this;
            cp.ShowDialog();
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
    }
}
