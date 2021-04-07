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

namespace Aplikasi_ProyekSDP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, RoutedEventArgs e)
        {
            if (username_input.Text == "master")
            {
                this.Hide();
                MasterWindow master = new MasterWindow();
                master.ShowDialog();
                this.Close();
            }
            else if (username_input.Text == "manager")
            {
                this.Hide();
                ManagerWindow manager = new ManagerWindow();
                manager.ShowDialog();
                this.Close();
            }
            else if (username_input.Text == "kasir")
            {
                this.Hide();
                OrderWindow order = new OrderWindow();
                order.ShowDialog();
                this.Close();
            }
        }
    }
}
