using System;
using System.Collections;
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

namespace WpfApp2
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();



        }

        public class Tarea
        {
            public Tarea()
            {

            }
            public Tarea (String nombre)
            {
                this.nombre=nombre;
            }
            public string nombre { get; set; }
            public Boolean hecho { get; set; }

        }

        public void Agregar_Click(object sender, RoutedEventArgs e)
        {
            DataGrid.Items.Add(new Tarea(TB_Tarea.Text));
            DataGrid.Items.Refresh();
            TB_Tarea.Text = string.Empty;
        }




    }
}
