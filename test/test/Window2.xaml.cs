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

namespace test
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window

    {
        private string image1 = @"\\sysprofiles.adm.vvsu.ru\STUDENTRPROFILES$\kirilkaurd2\Desktop\1.jpg";
        private string image2 = @"\\sysprofiles.adm.vvsu.ru\STUDENTRPROFILES$\kirilkaurd2\Desktop\2.png";
        private string image3 = @"\\sysprofiles.adm.vvsu.ru\STUDENTRPROFILES$\kirilkaurd2\Desktop\3.jpg";

        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void RadioButton3_Checked(object sender, RoutedEventArgs e)
        {
            DisplayImage.Source = new BitmapImage(new Uri(image1));
        }

        private void RadioButton2_Checked(object sender, RoutedEventArgs e)
        {
            DisplayImage.Source = new BitmapImage(new Uri(image2));
        }

        private void RadioButton1_Checked(object sender, RoutedEventArgs e)
        {
            DisplayImage.Source = new BitmapImage(new Uri(image3));
        }
    }
}
