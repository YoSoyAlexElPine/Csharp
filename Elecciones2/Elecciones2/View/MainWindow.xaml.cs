using System;

using Elecciones2.Party;
using Elecciones2.DataGrid;
using Elecciones2.Functions;

using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Collections.Generic;

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

        /*
         * Boton de la primera ventana que nos manda a la segunda
         * **/
        private void b_save_Click(object sender, RoutedEventArgs e)
        {
            tabItem2.IsEnabled = true;
            tabControl.SelectedItem = tabItem2;
            b_save2.IsEnabled = false;
        }

        //Ventana 2


        /*
        * Boton para agregar partido
        * **/
        public void New_Click(object Sender, RoutedEventArgs e)
        {

            // Verificamos si por lo menos hay dos partidos

            b_save2.IsEnabled=dg_partidos.Items.Count > 1;

            //Cotrolamos que no se puedan añadir mas de 10 partidos

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
                // Eliminamos la opcion de agregar mas partidos

                b_new.IsEnabled = false;

                // Mostramos mensaje
                MessageBox.Show("Numero maximo de partidos alcanzado");
            }

        }

        /*
         * Boton Save de la tengunda pestaña
         * **/
        public void Save_Click(object Sender, RoutedEventArgs e)
        {
            // Habilitamos el boton
            tabItem3.IsEnabled = true;

            // Entramos en la pestaña
            tabControl.SelectedItem = tabItem3;

        }

        /*
         * Boton Borrar elemetos seleccionados
         * **/

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            // Obtener los elementos seleccionados en el DataGrid
            List<Partido> selectedItems = new List<Partido>();
            foreach (Partido item in dg_partidos.SelectedItems)
            {
                selectedItems.Add(item);
            }

            // Borrar los elementos seleccionados
            foreach (Partido item in selectedItems)
            {
                dg_partidos.Items.Remove(item);
            }

            // Habilitar boton Si queda por lo menos 2 partidos
            b_save2.IsEnabled = dg_partidos.Items.Count > 1;

            // Habilitamos el boton new en caso de que queden menos de 10 partidos

            b_new.IsEnabled = dg_partidos.Items.Count < 10;

        }



        //Ventana 3

        /*
         * Conrolamos la tipica excepcino al hacer click en el datagrid
         * 
         * **/

        public void dg_partidos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                // Manejar la excepción de manera adecuada (mostrar un mensaje de error, registrarla, etc.).
            }

        }
    }
}