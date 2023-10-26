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

namespace My_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
    private void Boton_jugar_Click(object sender, RoutedEventArgs e)
    {
        VentanaJugar ventana = new VentanaJugar();
        ventana.Show();
    }

    private void Boton_fotos_Click(object sender, RoutedEventArgs e)
    {
        VentanaFotos ventana = new VentanaFotos();
        ventana.Show();
    }

    private void Boton_creditos_Click(object sender, RoutedEventArgs e)
    {
        VentanaCreditos ventana = new VentanaCreditos();
        ventana.Show();
    }
}
