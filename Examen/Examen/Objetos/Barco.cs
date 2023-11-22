using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Examen.Objetos
{
    class Barco
    {

        static int id;
        int size,barcoId;
        String nombre;

        public Barco()
        {
            barcoId = id++;
        }
        public Barco(int size, String nombre) {

            this.size = size;
            this.nombre = nombre;
            barcoId = id++;

        }

        public void cantar()
        {
            MessageBox.Show("Hola, soy un barco de "+this.size+" pixeles");
        }
    }
}
