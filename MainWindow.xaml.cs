using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RabusaBSIT301LongQuiz
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

        private void BtnClickP1(object sender, RoutedEventArgs e)
        {
            Main.Navigate(new Page1());
        }

        private void BtnClickP2(object sender, RoutedEventArgs e)
        {
            Main.Navigate(new Page2());
        }

        private void BtnClickP3(object sender, RoutedEventArgs e)
        {
            Main.Navigate(new Page3());
        }

        private void BtnClickP4(object sender, RoutedEventArgs e)
        {
            Main.Navigate(new Page4());
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Main_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}