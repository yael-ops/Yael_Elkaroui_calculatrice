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

namespace Yael_Elkaroui_calculatrice
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        double N1 = 0;
        double N2 = 0;
        double resultat = 0;
        char operation = ' ';



        private void BTN_1_Click(object sender, RoutedEventArgs e)
        {
            display("1");
        }

        private void BTN_2_Click(object sender, RoutedEventArgs e)
        {
            display("2");
        }

        private void BTN_3_Click(object sender, RoutedEventArgs e)
        {
            display("3");
        }

        private void BTN_4_Click(object sender, RoutedEventArgs e)
        {
            display("4");
        }

        private void BTN_5_Click(object sender, RoutedEventArgs e)
        {
            display("5");
        }

        private void BTN_6_Click(object sender, RoutedEventArgs e)
        {
            display("6");
        }

        private void BTN_7_Click(object sender, RoutedEventArgs e)
        {
            display("7");
        }

        private void BTN_8_Click(object sender, RoutedEventArgs e)
        {
            display("8");
        }

        private void BTN_9_Click(object sender, RoutedEventArgs e)
        {
            display("9");
        }

        private void BTN_0_Click(object sender, RoutedEventArgs e)
        {
            display("0");
        }



        public void display(string num)
        {

            if (TB_Resultat.Text == "0")
            {
                TB_Resultat.Text = num;
            }
            else
            {
                TB_Resultat.Text = TB_Resultat.Text + num;
            }
        }

        private void BTNplus_Click(object sender, RoutedEventArgs e)
        {
            N1 = Double.Parse(TB_Resultat.Text);
            operation = '+';
            TB_Resultat.Text = "";

        }

        private void BTNmoins_Click(object sender, RoutedEventArgs e)
        {
            N1 = Double.Parse(TB_Resultat.Text);
            operation = '-';
            TB_Resultat.Text = "";
            //guguyghh
        }

        private void BTNfois_Click(object sender, RoutedEventArgs e)
        {
            N1 = Double.Parse(TB_Resultat.Text);
            operation = '*';
            TB_Resultat.Text = "";

        }

        private void BTNdivise_Click(object sender, RoutedEventArgs e)
        {
            N1 = Double.Parse(TB_Resultat.Text);
            operation = '/';
            TB_Resultat.Text = "";

        }

        private void BTNegal_Click(object sender, RoutedEventArgs e)
        {
            N2 = Double.Parse(TB_Resultat.Text);
            switch (operation)
            {
                case '+':
                    resultat = N1 + N2;
                    TB_Resultat.Text = resultat.ToString();
                    break;
                case '-':
                    resultat = N1 - N2;
                    TB_Resultat.Text = resultat.ToString();
                    break;

                case '*':
                    resultat = N1 * N2;
                    TB_Resultat.Text = resultat.ToString();
                    break;
                case '/':
                    resultat = N1 / N2;
                    TB_Resultat.Text = resultat.ToString();
                    break;


            }
        }

        private void BTN_CLR_Click(object sender, RoutedEventArgs e)
        {
            TB_Resultat.Clear();
        }


        private void BTN_pi_Click(object sender, RoutedEventArgs e)
        {
            {
                N1 = Double.Parse(TB_Resultat.Text);
                operation = 'π';
                TB_Resultat.Text = "";
                resultat = N1 * Math.PI;
                TB_Resultat.Text = resultat.ToString();
            }
        }

        private void BTN_sqr_Click_1(object sender, RoutedEventArgs e)
        {
            N1 = Double.Parse(TB_Resultat.Text);
            operation = '√';
            TB_Resultat.Text = "";
            resultat = Math.Sqrt (N1);
            TB_Resultat.Text = resultat.ToString();
        }

        private void BTN_au_carre_Click(object sender, RoutedEventArgs e)
        {
            N1 = Double.Parse(TB_Resultat.Text);
            operation = '²';
            TB_Resultat.Text = "";
            resultat = N1*N1;
            TB_Resultat.Text = resultat.ToString();
        }

        private void BTN_pourcentage_Click(object sender, RoutedEventArgs e)
        {
            N1 = Double.Parse(TB_Resultat.Text);
            operation = '%';
            TB_Resultat.Text = "";
            resultat = N1 / 100;
            TB_Resultat.Text = resultat.ToString();
        }

        private void BTNvirgule_Click_1(object sender, RoutedEventArgs e)
        {
            if (!TB_Resultat.Text.Contains(","))
            {
                // Ajoutez une virgule au champ de texte
                TB_Resultat.Text += ",";
            }
        }

        private void BTN_sin_Click(object sender, RoutedEventArgs e)
        {
            N1 = Double.Parse(TB_Resultat.Text);
            operation = 'S';
            TB_Resultat.Text = "";
            resultat = Math.Sin(N1);
            TB_Resultat.Text = resultat.ToString();
        }

        private void BTN_cos_Click(object sender, RoutedEventArgs e)
        {
            N1 = Double.Parse(TB_Resultat.Text);
            operation = 'C';
            TB_Resultat.Text = "";
            resultat = Math.Cos(N1);
            TB_Resultat.Text = resultat.ToString();
        }

        private void BTN_tan_Click(object sender, RoutedEventArgs e)
        {
            N1 = Double.Parse(TB_Resultat.Text);
            operation = 'T';
            TB_Resultat.Text = "";
            resultat = Math.Tan(N1);
            TB_Resultat.Text = resultat.ToString();
        }
    }
}

