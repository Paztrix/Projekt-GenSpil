using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenSpil
{
    public class GameType
    {
        // Basisoplysninger
        public string Name { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
        public string Genre { get; set; }

        // Lister over spil og forespørgsler (privat, så de ikke kan ændres udefra)
        private List<Game> games = new List<Game>();
        private List<Request> requests = new List<Request>();

        // Tilføjer et spil til lageret med unikt ID
        public void AddGame(double price, string condition)
        {
            int nextId = games.Count + 1;
            games.Add(new Game(nextId, price, condition));
        }

        // Opretter en kundeforespørgsel med unikt ID
        public void CreateRequest(string name, string phone, string email)
        {
            int nextId = requests.Count + 1;
            requests.Add(new Request(nextId, DateTime.Now, name, phone, email));
        }

        // Vis antal forespørgsler
        public int RequestCount()
        {
            return requests.Count;
        }

        // Vis antal spil på lager (fratrækker spil, der er checket ud)
        public int InventoryCount()
        {
            return games.Count(g => !g.IsCheckedOut); // For hvert spil g i listen, returnér true hvis g.IsCheckedOut er false
        }

        // Viser en kopi af forespørgselslisten
        public List<Request> RequestList()
        {
            return new List<Request>(requests); // Returnerer en ny liste med samme indhold som requests, så den originale liste ikke ændres udefra
        }

        // Viser alle spilinformationer, lagerstatus og forespørgsler
        public void DisplayAll()
        {
            Console.WriteLine("\nAlle spil:");
            foreach (var game in games) // Viser alle spil på lager
                game.Display();

            Console.WriteLine("\nForespørgsler:");
            foreach (var request in requests) // Viser alle forespørgsler
                request.Display();
        }
    }
}
