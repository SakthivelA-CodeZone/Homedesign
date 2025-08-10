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

namespace Usingdock
{
    /// <summary>
    /// Interaction logic for FORLOGIN.xaml
    /// </summary>
    public partial class FORLOGIN : Window
    {
        public FORLOGIN()
        {
            InitializeComponent();
        }

        
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            txtlogin.Text=txtlogin.Text+"@gmail.com";
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            txtlogin.Text = string.Empty;
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(txtlogin.Text) )
            {
                MessageBox.Show("Please enter username");
            }
            else
            {
                MessageBox.Show("Login successful!");
                this.Close();
            }
        }
    }
}
