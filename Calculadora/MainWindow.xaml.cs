using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Calculadora
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        double num1=0, num2=0, res=0;
        string simbolo;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (result.Text == "0") result.Text = "0";
            else result.Text += "0";
        }

        private void Button_Click_coma(object sender, RoutedEventArgs e)
        {
            string patron = "[,]";
            Regex miRegex = new Regex(patron);
            MatchCollection elMatch = miRegex.Matches(result.Text);
            if(elMatch.Count < 1) result.Text += ",";

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (result.Text == "0") result.Text = "1";
            else result.Text += "1";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (result.Text == "0") result.Text = "2";
            else result.Text += "2";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (result.Text == "0") result.Text = "3";
            else result.Text += "3";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (result.Text == "0") result.Text = "4";
            else result.Text += "4";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (result.Text == "0") result.Text = "5";
            else result.Text += "5";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (result.Text == "0") result.Text = "6";
            else result.Text += "6";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (result.Text == "0") result.Text = "7";
            else result.Text += "7";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (result.Text == "0") result.Text = "8";
            else result.Text += "8";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if(result.Text=="0") result.Text = "9";
            else result.Text += "9";
        }

        private void Button_Click_menos(object sender, RoutedEventArgs e)
        {
            if (result.Text != "")
            {
                if (num1 == 0)
                {
                    num1 = double.Parse(result.Text);
                    result.Text = "";
                    simbolo = "-";
                    res += num1;
                    operador1.Text = num1 + simbolo;
                }
                else
                {
                    num2 = double.Parse(result.Text);
                    result.Text = "";
                    res = Operar(simbolo);
                    simbolo = "-";
                    operador1.Text = res + simbolo;

                }
            }
        }

        private void Button_Click_borrar(object sender, RoutedEventArgs e)
        {
            num1 = 0; num2 = 0; res = 0;
            simbolo="";
            result.Text = "0";
            operador1.Text = "";
        }

        private void Button_Click_multiplicar(object sender, RoutedEventArgs e)
        {
            if (result.Text != "")
            {
                if (num1 == 0)
                {
                    num1 = double.Parse(result.Text);
                    result.Text = "";
                    simbolo = "×";
                    res += num1;
                    operador1.Text = num1 + simbolo;
                }
                else
                {
                    num2 = double.Parse(result.Text);
                    result.Text = "";
                    res = Operar(simbolo);
                    simbolo = "×";
                    operador1.Text = res + simbolo;

                }
            }
        }

        private void Button_Click_dividir(object sender, RoutedEventArgs e)
        {
            if (result.Text != "")
            {
                if (num1 == 0)
                {
                    num1 = double.Parse(result.Text);
                    result.Text = "";
                    simbolo = "÷";
                    res += num1;
                    operador1.Text = num1 + simbolo;
                }
                else
                {
                    num2 = double.Parse(result.Text);
                    result.Text = "";
                    res = Operar(simbolo);
                    simbolo = "÷";
                    operador1.Text = res + simbolo;

                }
            }

        }

        private void Button_Click_igual(object sender, RoutedEventArgs e)
        {
            if (result.Text != "")
            {
                num2 = double.Parse(result.Text);
                res = Operar(simbolo);
            }
            simbolo = "";
            operador1.Text = "";
            result.Text = res +"";
            num1 = 0; num2 = 0; res = 0;
        }

        private void Button_Click_negar(object sender, RoutedEventArgs e)
        {
            if (result.Text != "")
            {
                res = double.Parse(result.Text) * (-1);
                result.Text = "";
                operador1.Text = res + "";
            }
            else
            {
                res = res * (-1);
                operador1.Text = res + "";
            }
            
        }

        private void Button_Click_borraUltimo(object sender, RoutedEventArgs e)
        {
            result.Text = result.Text.Remove(result.Text.Length - 1);
        }

        private void Button_Click_borrarNum2(object sender, RoutedEventArgs e)
        {
            result.Text = "0";
            
        }

        private void Button_Click_raiz(object sender, RoutedEventArgs e)
        {
           
            if (num1 == 0)
            {
                if (result.Text == "") num1 = 0;
                else num1 = double.Parse(result.Text);
                res = Math.Sqrt(num1);
                result.Text = res + "";

            }
            else
            {
                operador1.Text = "";
                res = Math.Sqrt(res);
                result.Text = res + "";
                num1 = 0;
                res = 0;
            }
            
        }

        private void Button_Click_cuadrado(object sender, RoutedEventArgs e)
        {
           
            if (num1 == 0)
            {
                if (result.Text == "") num1 = 0;
                else num1 = double.Parse(result.Text);
                res = Math.Pow(num1, 2);
                result.Text = res + "";
            }
            else
            {
                operador1.Text = "";
                res = Math.Pow(res, 2);
                result.Text = res + "";
                num1 = 0;
                res = 0;
            }
            
        }

        private void Button_Click_fraccion(object sender, RoutedEventArgs e)
        {
            if (num1 == 0)
            {
                if (result.Text == "") num1 = 0;
                else num1 = double.Parse(result.Text);
                res = 1/num1;
                result.Text = res + "";
            }
            else
            {
                operador1.Text = "";
                res = 1/res;
                result.Text = res + "";
                num1 = 0;
                res = 0;
            }
        }

        private void Button_Click_mas(object sender, RoutedEventArgs e)
        {
            if (result.Text != "")
            {
                if (num1 == 0)
                {
                    num1 = double.Parse(result.Text);
                    result.Text = "";
                    simbolo = "+";
                    res += num1;
                    operador1.Text = num1 + simbolo;
                }
                else
                {
                    num2 = double.Parse(result.Text);
                    result.Text = "";
                    res = Operar(simbolo);
                    simbolo = "+";
                    operador1.Text = res + simbolo;

                }
            }
            
        }

        private double Operar(string simbolo)
        {
            switch (simbolo)
            {
                case "+":
                    res = res + num2;
                    break;
                case "-":
                    res = res - num2;
                    break;
                case "×":
                    res = res * num2;
                    break;
                case "÷":
                    res = res / num2;
                    break;
                default:
                    break;
            }
            return res;
        }
    }
}
