using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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

namespace Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double numero1 = 0;
        double numero2 = 0;
        string operacion = "";
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Botigu_Click(object sender, RoutedEventArgs e)
        {
            double oper = 0;

            switch (operacion)
            {
                case "+":
                    oper = numero1 + numero2;
                    Result.Text = oper.ToString("N1");
                    break;
                case "-":
                    oper = numero1 - numero2;
                    Result.Text = oper.ToString("N1");
                    break;
                case "x":
                    oper = numero1 * numero2;
                    Result.Text = oper.ToString("N1");
                    break;
                case "÷":
                    oper = numero1 / numero2;
                    Result.Text = oper.ToString("N1");
                    break;
                default:
                    Result.Text = "Error!";
                    break;
            }
            numero1 = 0;
            numero2 = 0;
            operacion = "";
            Texto.Text = "";
        }
        private void BotAc_Click(object sender, RoutedEventArgs e)
        {
            numero1 = 0;
            numero2 = 0;
            operacion = "";
            Texto.Text = "";
            Result.Text = numero1.ToString();
        }
        private void Botsum_Click(object sender, RoutedEventArgs e)
        {
            operacion = "+";
            Texto.Text = "+";
        }
        private void Botres_Click(object sender, RoutedEventArgs e)
        {
            operacion = "-";
            Texto.Text = "-";
        }
        private void Botx_Click(object sender, RoutedEventArgs e)
        {
            operacion = "x";
            Texto.Text = "x";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            operacion = "÷";
            Texto.Text = "÷";
        }
        // INICIA VALIDACIÓN DE BOTONES
        private void Trabaja(int opcion)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + opcion;
                Result.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + opcion;
                Result.Text = numero2.ToString();
            }
        }
        private void Bot0_Click(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + 0;
                Result.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 0;
                Result.Text = numero2.ToString();
            }
        }
        private void Bot1_Click(object sender, RoutedEventArgs e)
        {
            Trabaja(1);
        }
        private void Bot2_Click(object sender, RoutedEventArgs e)
        {
            Trabaja(2);
        }

        private void Bot3_Click(object sender, RoutedEventArgs e)
        {
            Trabaja(3);
        }
        private void Bot4_Click(object sender, RoutedEventArgs e)
        {
            Trabaja(4);
        }
        private void Bot5_Click(object sender, RoutedEventArgs e)
        {
            Trabaja(5);
        }
        private void Bot6_Click(object sender, RoutedEventArgs e)
        {
            Trabaja(6);
        }
        private void Bot7_Click(object sender, RoutedEventArgs e)
        {
            Trabaja(7);
        }
        private void Bot8_Click(object sender, RoutedEventArgs e)
        {
            Trabaja(8);
        }
        private void Bot9_Click(object sender, RoutedEventArgs e)
        {
            Trabaja(9);
        }
        private void BotSi_Click(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = numero1 * (-1);
                Result.Text = numero1.ToString();
            }
            else
            {
                numero2 = numero2 * (-1);
                Result.Text = numero2.ToString();
            }
        }

        private void Botpun_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Botpr_Click(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = numero1 * 0;
                Result.Text = numero1.ToString();
            }
            else
            {
                numero2 = numero2 / 100;
                Result.Text = numero2.ToString();
            }
        }
    }
}
