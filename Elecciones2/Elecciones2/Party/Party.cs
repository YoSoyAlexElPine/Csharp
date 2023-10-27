using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elecciones2.Party
{
    class Partido
    {
        private int votos, escanos;
        Boolean representacion;
        string resultado, nombre, presidente, acronimo;
       
        public Partido(String presidente, String acronimo, String nombre)
        {
            

            this.presidente = presidente;
            this.acronimo = acronimo;
            this.nombre = nombre;
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

        public string Presidente
        {
            get { return presidente; }
        }

        public string Acronimo
        {
            get { return acronimo; }
        }

        public string Nombre
        {
            get { return nombre; }
        }


    }
}
