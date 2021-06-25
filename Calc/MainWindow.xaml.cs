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

namespace Calc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string leftop = "";
        public string operation = "";
        public string rightop = "";
        public MainWindow()
        {
            InitializeComponent();
            if (TXT.Text.Length <= 15)
            {
                btn0.IsEnabled = true;
                btn1.IsEnabled = true;
                btn2.IsEnabled = true;
                btn3.IsEnabled = true;
                btn4.IsEnabled = true;
                btn5.IsEnabled = true;
                btn6.IsEnabled = true;
                btn7.IsEnabled = true;
                btn8.IsEnabled = true;
                btn9.IsEnabled = true;
            }
            else
            {
                btn0.IsEnabled = false;
                btn1.IsEnabled = false;
                btn2.IsEnabled = false;
                btn3.IsEnabled = false;
                btn4.IsEnabled = false;
                btn5.IsEnabled = false;
                btn6.IsEnabled = false;
                btn7.IsEnabled = false;
                btn8.IsEnabled = false;
                btn9.IsEnabled = false;
            }
            TXT.Text.Where(ch =>
            ch == '+' || ch == '-'
            || (ch >= '0' && ch <= '9')
            || (ch >= 'a' && ch <= 'я')
            || (ch >= 'A' && ch <= 'Я')
            || (ch == 'ё' && ch == 'Ё')
            ).ToArray();

            foreach (UIElement c in LayoutRoot.Children)
            {
                if (c is Button)
                {
                    ((Button)c).Click += Button_Click;
                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string s = (string)((Button)e.OriginalSource).Content;
            TXT.Text += s;
            double num;
            bool result = Double.TryParse(s, out num);
            if (result == true)
            {
                if (operation == "")
                {
                    leftop += s;
                }
                else
                {
                    rightop += s;
                }
            }
            else
            {
                if (s == "=")
                {
                    Update_RightOp();
                    txb.Text = rightop;
                    TXT.Text += rightop;
                    operation = "";
                }
                else if (s == "c")
                {
                    leftop = "";
                    rightop = "";
                    operation = "";
                    txb.Text = "";
                    TXT.Text = "";
                }
                else if (s == "<-")
                {
                    string k = TXT.Text;
                    if (k.Length > 1)
                    {
                        k = k.Substring(0, k.Length - 3);
                    }
                    else
                    {
                        k = "0";
                    }
                    TXT.Text = k;

                }
                else
                {
                    if (rightop != "")
                    {
                        Update_RightOp();
                        leftop = rightop;
                        rightop = "";
                    }
                    operation = s;
                }
            }
        }

        private void Update_RightOp()
        {
            double num1 = Int32.Parse(leftop);
            double num2 = Int32.Parse(rightop);
            switch (operation)
            {
                case "+":
                    rightop = Writing.Plus(num1, num2).ToString();
                    break;
                case "-":
                    rightop = Writing.Minus(num1, num2).ToString();
                    break;
                case "*":
                    rightop = Writing.multip(num1, num2).ToString();
                    break;
                case "/":
                    if (num2==0)
                    {
                        rightop = "На ноль делить нельзя";
                    }
                    else
                    rightop = Writing.Del(num1, num2).ToString();
                    break;
                case "%":
                    rightop = Writing.Hop(num1, num2).ToString();
                    break;
            }
        }


    }
}
