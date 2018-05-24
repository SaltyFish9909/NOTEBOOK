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

namespace WPF_NOTE
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();

            Nullable<bool> result = dlg.ShowDialog();

            //存档路径
            if (result == true)
            {
                System.IO.File.WriteAllText(dlg.FileName, Textarea.Text);
            }
        }

        private void OpenBtn_Click(object sender, RoutedEventArgs e)
        {
            //读档路径
            //Textarea.Text = System.IO.File.ReadAllText(@"C:\temp\aaa.txt");
        }
    }
}
