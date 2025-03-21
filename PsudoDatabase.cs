using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace GenSpil
{
    public static class PsudoDatabase
    {
        public static List<Game> games = new List<Game>();
        public static List<Request> requests = new List<Request>();
        public static List<GameType> gametypes = new List<GameType>();

        public static void DatabaseSeeder()
        {
            this.games.Add(gameType: new Game(new GameType(title: "Jumanji", minAge:12, minPalyers:3, maxPlayers:6, genre: Genre.Familygame ), prize: 99.95, Condition: Condition.Fine );
            this.games.Add(gameType: new Game(new GameType(title: "Monopoly", minAge: 8, minPalyers: 2, maxPlayers: 8, genre: Genre.Familygame), prize: 129.95, Condition: Condition.Perfect);
        }
    }
}
