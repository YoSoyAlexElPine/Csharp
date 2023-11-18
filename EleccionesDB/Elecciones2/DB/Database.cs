using Elecciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Windows;
using Elecciones2.Party;

namespace Elecciones2.DB
{
    class Database
    {
        public static string connectionString = "Server=localhost;Database=elecciones;Uid=root;Pwd=1234;";

        public static void Prueba1()
        {


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string sqlQuery = "SELECT * FROM partido WHERE acronimo = 'PP'";
                    MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MessageBox.Show($"{reader["id"]}, {reader["acronimo"]}, {reader["nombre"]}, {reader["presidente"]}, {reader["votos"]}, {reader["seats"]}, {reader["representacion"]}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public static void Insertar(String tabla, String datos,String valores)
        {

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string sqlQuery = "INSERT INTO " + tabla + "(" + datos + ") VALUES (" + valores + ")";
                    MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insercion");
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public static void InsertarParty(Partido partido)
        {

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    int representacion = 0;

                    if (partido.Representacion)
                    {
                        representacion = 1;
                    }

                    string sqlQuery = "INSERT INTO partido (acronimo, nombre, presidente, votos, seats, representacion) VALUES ('" 
                        + partido.Acronimo +"','"+ partido.Nombre + "','" + partido.Presidente + "','" + partido.Votos + "','" + partido.Seats + "','" + representacion+ "')";
                    MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insercion Error: " + ex.Message);
                }
            }
        }

        public static void EliminarParty(Partido partido)
        {


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    MySqlCommand modoSeguro = new MySqlCommand("SET SQL_SAFE_UPDATES = 0;", connection);
                    modoSeguro.ExecuteNonQuery();

                    string sqlQuery = "DELETE FROM partido WHERE acronimo = '" + partido.Acronimo + "'";
                    MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);
                    cmd.ExecuteNonQuery();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete Error: " + ex.Message);
                }
            }
        }
        public static List<Partido> ObtenerTodosLosPartidos()
        {
            List<Partido> partidos = new List<Partido>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM partido";

                MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);

                try
                {
                    connection.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Partido partido = new Partido(
                                reader["presidente"].ToString(),
                                reader["acronimo"].ToString(),
                                reader["nombre"].ToString()
                            );

                            // Otros atributos del partido
                            partido.SetVotos(int.Parse(reader["votos"].ToString()));
                            partido.SetSeats(int.Parse(reader["seats"].ToString()));


                            Boolean representacion = false;

                            if (reader["representacion"].ToString() == "1")
                            {
                                representacion = true;
                            }

                            partido.SetRepresentacion(representacion);

                            partidos.Add(partido);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return partidos;
        }

    }
}
