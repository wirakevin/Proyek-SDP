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
    /// Interaction logic for MasterWindow.xaml
    /// </summary>
    public partial class MasterWindow : Window
    {
        public MasterWindow()
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

        private void insert_btn_Click(object sender, RoutedEventArgs e)
        {
            InsertuserWindow iu = new InsertuserWindow();
            iu.Owner = this;
            iu.ShowDialog();
        }

        private void update_btn_Click(object sender, RoutedEventArgs e)
        {
            UpdateuserWindow uu = new UpdateuserWindow();
            uu.Owner = this;
            uu.ShowDialog();
        }

        private void delete_btn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
