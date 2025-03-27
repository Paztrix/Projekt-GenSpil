namespace GenSpil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PsudoDatabase.DatabaseSeeder();

            foreach (var game in PsudoDatabase.games) 
            { 
                Console.WriteLine($"{game.type.Name}, {game.price}");
            }

            Request.DisplayRequests();
        }
    }
}
