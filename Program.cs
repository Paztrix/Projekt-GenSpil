namespace GenSpil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var games = PsudoDatabase.games;


            foreach (var game in games) 
            { 
                Console.WriteLine($"{game.gameType.Name}, {game.prize}");
            }



        }
    }
}
