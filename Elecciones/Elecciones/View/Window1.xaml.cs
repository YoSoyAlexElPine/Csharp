using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Elecciones
{

    class Partido
    {
        private int votos, escanos, validos, umbral, escanoUmbral;
        Boolean representacion;
        string resultado;
        public Partido(int votos, int validos, int umbral)
        {
            this.escanos = 0;
            this.votos = votos;
            this.validos = validos;
            this.umbral = umbral;

            escanoUmbral = validos / 37;

            if (votos < umbral)
            {
                representacion = false;
                resultado = "No representation";
            }
            else
            {
                representacion = true;
            }

            if (representacion)
            {
                for (int i = 2; i < 18; i++)
                {
                    if ((votos / i) > escanoUmbral)
                    {
                        escanos++;
                    }
                }
                resultado = escanos.ToString();
            }




        }

        public int Votos
        {
            get { return votos; }
        }

        public int Escanos
        {
            get { return escanos; }
        }

        public string Resultado
        {
            get { return resultado; }
        }


    }

    //Ventana 1



    public partial class MainWindow : Window
    {
        int totalVotos, nulos, abstenciones, validos, umbral;
        public int poblacion = 6921267;
        public MainWindow()
        {
            InitializeComponent();

            tb_population.IsEnabled = false;
            tb_population.Text = poblacion.ToString();
            b_save.IsEnabled = false;
            tabItem2.IsEnabled = false;
            tabItem3.IsEnabled = false;

        }


        private bool verificacion1()
        {

            if (!string.IsNullOrWhiteSpace(tb_population.Text) && !string.IsNullOrWhiteSpace(tb_abstentionsVotes.Text) && !string.IsNullOrWhiteSpace(tb_nullVotes.Text))
            {

                nulos = int.Parse(new string(tb_nullVotes.Text.Where(char.IsDigit).ToArray()));
                abstenciones = int.Parse(new string(tb_abstentionsVotes.Text.Where(char.IsDigit).ToArray()));
                poblacion = int.Parse(new string(tb_population.Text.Where(char.IsDigit).ToArray()));
                validos = poblacion - abstenciones - nulos;
                umbral = (int)(validos * 0.03);

                if (abstenciones + nulos < poblacion)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox)
            {

                textBox.Text = new string(textBox.Text.Where(char.IsDigit).ToArray()); // Elimina caracteres no numéricos


                // Formatea el número al perder el foco
                if (decimal.TryParse(textBox.Text, out decimal value))
                {
                    // Asegúrate de que no haya decimales
                    textBox.Text = Math.Round(value).ToString("N0");
                }
            }

            if (verificacion1())
            {
                b_save.IsEnabled = true;
            }
            else
            {
                b_save.IsEnabled = false;
            }



        }

        private void b_save_Click(object sender, RoutedEventArgs e)
        {
            nulos = int.Parse(new string(tb_nullVotes.Text.Where(char.IsDigit).ToArray()));
            abstenciones = int.Parse(new string(tb_abstentionsVotes.Text.Where(char.IsDigit).ToArray()));
            poblacion = int.Parse(new string(tb_population.Text.Where(char.IsDigit).ToArray()));
            validos = poblacion - abstenciones - nulos;
            umbral = (int)(validos * 0.03);

            tabItem2.IsEnabled = true;
        }

        //Ventana 2

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {



            tabItem3.IsEnabled = true;
        }

        private void TextBox_LostFocus2(object sender, RoutedEventArgs e)
        {
            Partido[] partidos = new Partido[10];
            if (sender is TextBox textBox)
            {

                textBox.Text = new string(textBox.Text.Where(char.IsDigit).ToArray());





                // Formatea el número al perder el foco
                if (decimal.TryParse(textBox.Text, out decimal value))
                {
                    // Asegúrate de que no haya decimales
                    textBox.Text = Math.Round(value).ToString("N0");
                }




            }

            if (verificacion2())
            {

                totalVotos = 0;

                partidos[0] = new Partido(int.Parse(new string(tb_team1.Text.Where(char.IsDigit).ToArray())), validos, umbral);
                partidos[1] = new Partido(int.Parse(new string(tb_team2.Text.Where(char.IsDigit).ToArray())), validos, umbral);
                partidos[2] = new Partido(int.Parse(new string(tb_team3.Text.Where(char.IsDigit).ToArray())), validos, umbral);
                partidos[3] = new Partido(int.Parse(new string(tb_team4.Text.Where(char.IsDigit).ToArray())), validos, umbral);
                partidos[4] = new Partido(int.Parse(new string(tb_team5.Text.Where(char.IsDigit).ToArray())), validos, umbral);
                partidos[5] = new Partido(int.Parse(new string(tb_team6.Text.Where(char.IsDigit).ToArray())), validos, umbral);
                partidos[6] = new Partido(int.Parse(new string(tb_team7.Text.Where(char.IsDigit).ToArray())), validos, umbral);
                partidos[7] = new Partido(int.Parse(new string(tb_team8.Text.Where(char.IsDigit).ToArray())), validos, umbral);
                partidos[8] = new Partido(int.Parse(new string(tb_team9.Text.Where(char.IsDigit).ToArray())), validos, umbral);
                partidos[9] = new Partido(int.Parse(new string(tb_team10.Text.Where(char.IsDigit).ToArray())), validos, umbral);

                seats1.Content = partidos[0].Resultado;
                seats2.Content = partidos[1].Resultado;
                seats3.Content = partidos[2].Resultado;
                seats4.Content = partidos[3].Resultado;
                seats5.Content = partidos[4].Resultado;
                seats6.Content = partidos[5].Resultado;
                seats7.Content = partidos[6].Resultado;
                seats8.Content = partidos[7].Resultado;
                seats9.Content = partidos[8].Resultado;
                seats10.Content = partidos[9].Resultado;

                for (int i = 0; i < 10; i++)
                {
                    totalVotos += partidos[i].Votos;
                }

                if (totalVotos < validos)
                {
                    Calculate.IsEnabled = true;
                }
                else
                {
                    Calculate.IsEnabled = false;
                }


            }
            else
            {
                Calculate.IsEnabled = false;
            }
        }

        private bool verificacion2()
        {
            if (!string.IsNullOrEmpty(tb_team1.Text) && !string.IsNullOrEmpty(tb_team2.Text) && !string.IsNullOrEmpty(tb_team3.Text) && !string.IsNullOrEmpty(tb_team4.Text) && !string.IsNullOrEmpty(tb_team5.Text) && !string.IsNullOrEmpty(tb_team6.Text) && !string.IsNullOrEmpty(tb_team7.Text) && !string.IsNullOrEmpty(tb_team8.Text) && !string.IsNullOrEmpty(tb_team9.Text) && !string.IsNullOrEmpty(tb_team10.Text))
            {
                if (true)
                {

                }


                return true;
            }
            else
            {
                return false;
            };
        }

        //Ventana 3


        private void Button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}
