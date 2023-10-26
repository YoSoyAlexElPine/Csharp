using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elecciones2.Party
{
    class Partido
    {
        private int votos, escanos, validos, umbral, escanoUmbral;
        Boolean representacion;
        string resultado, nombre, presidente, acronimo;
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
