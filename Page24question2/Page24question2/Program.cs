using System;

namespace Page24question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Game G1 = new Game("Basketball", 5, false);
            Game G2 = new Game("Football", 11, false);
            Game G3 = new Game("Vollyball", 5, true);

            Country Israel = new Country("Israel");
            Israel.AddGame(G1);
            Israel.AddGame(G2);
            Israel.AddGame(G3);
            Console.WriteLine(Israel);
            Israel.RemoveGame(G1);
            Console.WriteLine(Israel);
        }
    }
}
