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
    /// Interaction logic for ConfirmpayWindow.xaml
    /// </summary>
    public partial class ConfirmpayWindow : Window
    {
        public ConfirmpayWindow()
        {
            InitializeComponent();
        }

        private void confirm_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void cancel_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
