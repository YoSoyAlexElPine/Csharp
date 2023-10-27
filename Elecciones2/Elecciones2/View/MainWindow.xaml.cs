using System;

using Elecciones2.Party;
using Elecciones2.Functions;

using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Elecciones
{

    // Ventana 

    public partial class MainWindow : Window
    {
        public int poblacion = 6748929;
        public MainWindow()
        {

            InitializeComponent();

            tb_nullVotes.IsEnabled = false;
            tb_population.IsEnabled = false;
            tb_population.Text = poblacion.ToString();
            b_save.IsEnabled = false;
            tabItem2.IsEnabled = false;
            tabItem3.IsEnabled = false;

        }




        private void Solo_Numeros(object sender, TextCompositionEventArgs e)
        {
            
            // Usar una expresión regular para permitir solo números
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.Text, "^[0-9]+$"))
            {
                e.Handled = true; // No permitir la entrada de letras
            }
        }

            private void TB_Cambio(object sender, RoutedEventArgs e)
            {
                try
                {
                    int nulos = int.Parse(tb_abstentionsVotes.Text);

                    if (nulos.ToString().Length < 10 && nulos<=poblacion)    

                    {
                        b_save.IsEnabled = true;
                        tb_nullVotes.Text = (poblacion-nulos).ToString();
                    }
                    else
                    {
                        tb_nullVotes.Text = "-";
                        b_save.IsEnabled = false;
                    }


                }
                 catch (Exception ex)
                {
                    tb_nullVotes.Text = "-";
                    b_save.IsEnabled = false;
            }
            }

        private void b_save_Click(object sender, RoutedEventArgs e)
        {
            tabItem2.IsEnabled = true;
            tabControl.SelectedItem = tabItem2;
        }

        //Ventana 2



        public void New_Click(object Sender, RoutedEventArgs e)
        {

            if (dg_partidos.Items.Count <= 0)
            {
                b_save2.IsEnabled=false;
            } else
            {
                b_save2.IsEnabled = true;
            }

            if (dg_partidos.Items.Count < 10)
            { 
                if (tb_acronym.Text!="" && tb_party.Text != "" && tb_president.Text != "")
                {

                    // Creamos y agregamos partido
                    Partido party = new Partido(tb_president.Text, tb_acronym.Text, tb_party.Text);

                    dg_partidos.Items.Add(party);

                    // Vacioamos campos
                    tb_acronym.Text = string.Empty;
                    tb_party.Text = string.Empty;
                    tb_president.Text = string.Empty;

                }
            } else
            {
                b_new.IsEnabled = false;
            }

        }
        public void Save_Click(object Sender, RoutedEventArgs e)
        {

            if (dg_partidos.Items.Count>1)
            {


            }

        }



        private void Calculate_Click(object sender, RoutedEventArgs e)
        {



            tabItem3.IsEnabled = true;
        }

        private void TextBox_LostFocus2(object sender, RoutedEventArgs e)
        {

            /*if (verificacion2())
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
            }*/
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            dg_partidos.Items.Clear();
            b_new.IsEnabled = true;
        }

        /*private bool verificacion2()
        {
            if (!string.IsNullOrEmpty(tb_team1.Text) && !string.IsNullOrEmpty(tb_team2.Text) && !string.IsNullOrEmpty(tb_team3.Text) && !string.IsNullOrEmpty(tb_team4.Text) && !string.IsNullOrEmpty(tb_team5.Text) && !string.IsNullOrEmpty(tb_team6.Text) && !string.IsNullOrEmpty(tb_team7.Text) && !string.IsNullOrEmpty(tb_team8.Text) && !string.IsNullOrEmpty(tb_team9.Text) && !string.IsNullOrEmpty(tb_team10.Text))
            {
                return true;
            }
            else
            {
                return false;
            };
        }*/

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