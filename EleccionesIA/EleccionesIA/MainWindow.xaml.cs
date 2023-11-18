using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace EleccionesIA
{
    public partial class MainWindow : Window
    {
        private List<Party> parties = new List<Party>();
        private int population = 6921267; // Población fija
        private int voters;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(votersTextBox.Text, out voters))
            {
                EnableNextTab();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese datos válidos.");
            }
        }

        private void AddText(object sender, RoutedEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox.Text == "Nombre" || textBox.Text == "Acrónimo" || textBox.Text == "Presidente")
            {
                textBox.Text = string.Empty;
            }
        }

        private void RemoveText(object sender, RoutedEventArgs e)
        {
            var textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = textBox.Name switch
                {
                    "partyNameTextBox" => "Nombre",
                    "partyAcronymTextBox" => "Acrónimo",
                    "partyPresidentTextBox" => "Presidente",
                    _ => string.Empty
                };
            }
        }

        private void AddPartyButton_Click(object sender, RoutedEventArgs e)
        {
            if (parties.Count < 10)
            {
                var name = partyNameTextBox.Text;
                var acronym = partyAcronymTextBox.Text;
                var president = partyPresidentTextBox.Text;

                if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(acronym))
                {
                    parties.Add(new Party(name, acronym, president));
                    partyNameTextBox.Clear();
                    partyAcronymTextBox.Clear();
                    partyPresidentTextBox.Clear();
                    partiesDataGrid.ItemsSource = null;
                    partiesDataGrid.ItemsSource = parties;
                }
                else
                {
                    MessageBox.Show("Por favor, complete los campos obligatorios.");
                }
            }
            else
            {
                MessageBox.Show("No se pueden agregar más de 10 partidos.");
            }
        }

        private void CalculateSeatsButton_Click(object sender, RoutedEventArgs e)
        {
            if (parties.Any() && int.TryParse(seatsTextBox.Text, out int seats))
            {
                // Realiza la simulación de elecciones usando la Ley D'Hondt.
                var results = SimulateElectionsByDHondt(parties, voters, seats);

                // Muestra los resultados en un DataGrid.
                resultsDataGrid.Items.Clear();
                foreach (var party in parties)
                {
                    resultsDataGrid.Items.Add(party);
                }
                resultsDataGrid.Items.Add(new Party("Void","Void","Void"));
            }
            else
            {
                MessageBox.Show("Agregue al menos un partido político y proporcione el número de escaños para simular las elecciones.");
            }
        }



        private List<ElectionResult> SimulateElectionsByDHondt(List<Party> parties, int totalVotes, int seats)
        {
            var results = new List<ElectionResult>();
            var validVotes = totalVotes - CalculateVoidVotes(totalVotes);
            var remainingSeats = seats;
            var cont = 0;

            foreach (var party in parties)
            {
                cont++;
                party.Seats = 0; // Inicializa los escaños del partido a 0
                switch (cont)
                {
                    case 1:
                        party.Votes = ((int)Math.Truncate(validVotes * 0.3525));
                        break;
                    case 2:
                        party.Votes = ((int)Math.Truncate(validVotes * 0.2475));
                        break;
                    case 3:
                        party.Votes = ((int)Math.Truncate(validVotes * 0.1575));
                        break;
                    case 4:
                        party.Votes = ((int)Math.Truncate(validVotes * 0.1425));
                        break;
                    case 5:
                        party.Votes = ((int)Math.Truncate(validVotes * 0.0375));
                        break;
                    case 6:
                        party.Votes = ((int)Math.Truncate(validVotes * 0.0325));
                        break;
                    case 7:
                        party.Votes = ((int)Math.Truncate(validVotes * 0.015));
                        break;
                    case 8:
                        party.Votes = ((int)Math.Truncate(validVotes * 0.005));
                        break;
                    case 9:
                        party.Votes = ((int)Math.Truncate(validVotes * 0.0025));
                        break;
                    case 10:
                        party.Votes = ((int)Math.Truncate(validVotes * 0.0025));
                        break;
                    default:
                        party.Votes = 0;
                        break;
                }
            }

            while (remainingSeats > 0)
            {
                double maxQuotient = 0;
                Party maxParty = null;

                foreach (var party in parties)
                {
                    var quotient = (double)party.Votes / (party.Seats + 1); // Calcula el cociente para el partido

                    if (quotient > maxQuotient)
                    {
                        maxQuotient = quotient;
                        maxParty = party;
                    }
                }

                if (maxParty != null)
                {
                    maxParty.Seats++; // Asigna el escaño al partido con el cociente máximo
                    remainingSeats--;
                }
                else
                {
                    break;
                }
            }

            foreach (var party in parties)
            {
                results.Add(new ElectionResult
                {
                    Acronym = party.Acronym,
                    Seats = party.Seats
                });
            }

            // Filtra los resultados para mostrar solo los partidos presentes en el segundo DataGrid
            var filteredResults = results.Where(r => parties.Any(p => p.Acronym == r.Acronym)).ToList();

            return filteredResults;
        }




        private int CalculateVoidVotes(int totalVotes)
        {
            return (int)Math.Ceiling(totalVotes / 20.0);
        }

        private void EnableNextTab()
        {
            if (tabControl.SelectedIndex < tabControl.Items.Count - 1)
            {
                tabControl.SelectedIndex++;
            }
        }
    }

    public class Party
    {
        public string Name { get; set; }
        public int Votes { get; set; }

        public string Acronym { get; set; }
        public string President { get; set; }
        public int Seats { get; set; }

        public Party(string name, string acronym, string president)
        {
            Name = name;
            Acronym = acronym;
            President = president;
            Seats = 0;
        }
    }

    public class ElectionResult
    {
        public string Acronym { get; set; }
        public int Seats { get; set; }
    }
}
