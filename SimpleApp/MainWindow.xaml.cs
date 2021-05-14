using System.Data;
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

namespace SimpleApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach (UIElement el in MainView.Children) 
            {
                // Rashid
                if(el is Button button)
                {
                    button.Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;

            if(str =="AC")
            textlabel.Text = "";
            else if(str =="=")
            {
                string value = new DataTable().Compute(textlabel.Text, null).ToString();
                textlabel.Text = value;
            }
            else
                textlabel.Text += str;
        }
    }
}
