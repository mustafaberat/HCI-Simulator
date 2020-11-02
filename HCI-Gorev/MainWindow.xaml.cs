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

namespace HCI_Gorev
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void baslabtn_Click(object sender, RoutedEventArgs e)
        {
            if(textBoxName.Text.Trim() != "")
            {
                Test1 test1 = new Test1(textBoxName.Text);
                test1.Show();
                test1.showName();
                this.Close(); 
            }
        }
    }
}
