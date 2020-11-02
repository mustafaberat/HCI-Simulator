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

namespace HCI_Gorev
{
    /// <summary>
    /// test1.xaml etkileşim mantığı
    /// </summary>
    public partial class Test1: Window
    {
        private string Isim { get; set; }
        public Test1(string isim = "NULL")
        {
            InitializeComponent();
            Isim = isim;
        }

        public void showName()
        {
            MessageBox.Show(Isim, "My App");
        }

    }
}
