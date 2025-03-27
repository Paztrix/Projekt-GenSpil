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
        //public Enum Genre { get; set; }


        public GameType(string Name, string Description = "", int MinAge = 0, int minPlayers = 0, int maxPlayers = 99 )
        {
            this.Name = Name;
            this.Description = Description;
            this.Age = MinAge;
            this.MinPlayers = minPlayers;
            this.MaxPlayers = maxPlayers;
            //this.Genre = genre;
        }
    }
}
