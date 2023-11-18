using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Elecciones2.Party
{
    class Partido
    {
        int votos, seats;
        Boolean representacion;
        string resultado, nombre, presidente, acronimo;
       
        public Partido(String presidente, String acronimo, String nombre)
        {
            
            votos = 0; seats = 0; representacion = false;

            this.presidente = presidente;
            this.acronimo = acronimo;
            this.nombre = nombre;

        }

        public void calculateSeats(int validVotes,int seats,int votesSeat)
        {
            double umbral = (double)validVotes / seats;

            for (int i = 2; i < 18; i++)
            {
                if (this.votos/i > votesSeat)
                {
                    this.seats++;
                }
            }


            representacion = this.seats > umbral;


        }

        public void SetVotos(int votos)
        {
            this.votos = votos;
        }

        public void SetSeats(int seats)
        {
            this.seats = seats;
        }

        public void SetRepresentacion(Boolean repre)
        {
            this.representacion = repre;
        }


        public int Votos
        {
            get { return votos; }
            set { votos = value; }
        }

        public int Seats
        {
            set { seats = value; }
            get { return seats; }
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

        public Boolean Representacion
        {
            get { return representacion; }
        }


    }

}
