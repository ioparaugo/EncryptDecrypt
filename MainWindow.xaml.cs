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

namespace EncryptDecryptTool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            valueTxt.Text = "apiadminuser|J!J@R#I$H%K^F&R*2021|20210817"; //default value
        }


        private void btnDecrypt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(valueTxt.Text))
                {
                    resultTxt.Text = Crypto.TripleDESDecrypt(valueTxt.Text);
                }
            }
            catch(Exception ex)
            {
                resultTxt.Text = ex.Message;
            }
        }

        private void btnEncrypt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(valueTxt.Text))
                {
                    resultTxt.Text = Crypto.TripleDESEncrypt(valueTxt.Text);
                }
            }
            catch(Exception ex)
            {
                resultTxt.Text = ex.Message;
            }
        }

        private void valueTxt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
