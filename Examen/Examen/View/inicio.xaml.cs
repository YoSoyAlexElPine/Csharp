using Examen.Objetos;
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
using System.Windows.Shapes;

namespace Examen.View
{
    /// <summary>
    /// Lógica de interacción para inicio.xaml
    /// </summary>
    public partial class inicio : Window
    {
        public inicio()
        {
            InitializeComponent();

            // new Barco(10).cantar();

        }


        private void tb_a_TextChanged(object sender, TextChangedEventArgs e)
        {
            l_a.Content=tb_a.Text;
        }

        private void tb_b_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tb_c_TextChanged(object sender, TextChangedEventArgs e)
        {

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

        /*
         * Boton de la primera ventana que nos manda a la segunda
         **/
        private void b_save_Click2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("pulsado jiji");

        }

        /*
         * Conrolamos la tipica excepcino al hacer click en el datagrid
         * 
         **/

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
