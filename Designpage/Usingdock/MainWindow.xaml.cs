using System.Windows;
using Usingdock.Insidepage;
namespace Usingdock
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

        private void Newing_Click(object sender, RoutedEventArgs e)
        {
            Addpage addpage = new Addpage();
            Mainwindow.Content = addpage;

        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            Pagedock pagedock = new Pagedock();
            Mainwindow.Content = pagedock;

        }

        private void saving_Click(object sender, RoutedEventArgs e)
        {
            Pagepass  pagepass = new Pagepass();
            Mainwindow.Content = pagepass;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if(Mainwindow.CanGoBack)
            {
                Mainwindow.GoBack();
            }
           
        }

        private void FORWARD_Click(object sender, RoutedEventArgs e)
        {
            if (Mainwindow.CanGoForward)
            {
                Mainwindow.GoForward();
            }
           

        }
    }
}