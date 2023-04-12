using System;

namespace Page27_28Question2
{
    class Program
    {
        public static int ActorsPartInMoreThanNum(Actor[] Arr, int num)
        {
            int Count = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                if(Arr[i].GetNumFilms() > num)
                {
                    Count++;
                }
            }
            return Count;
        }

        static void Main(string[] args)
        {
            Actor A1 = new Actor("Kim Or Azulay", 278449, "F", 11);
            Actor A2 = new Actor("Maya Key", 215988, "F", 1);
            Actor A3 = new Actor("Shahar Hason", 280800, "M", 6);
            Actor A4 = new Actor("Kim Zalzuly Shimon Peretch", 278449, "F", 0);

            Oscar Comedy = new Oscar("Comedy");

            Comedy.AddActor(A1);
            Comedy.AddActor(A2);
            Comedy.AddActor(A3);
            Comedy.AddActor(A4);

            Console.WriteLine(Comedy);

            Actor[] Arr = {A1, A2, A3};
            int FilmsToCheck = 5;
            Console.WriteLine("There are: " + ActorsPartInMoreThanNum(Arr , 5) + " actors that took part in at least " + FilmsToCheck + " films");
        }
    }
}
