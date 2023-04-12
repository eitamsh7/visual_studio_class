using System;

namespace FarmManagement
{
    class Program
    {
        // טענת כניסה: הפעולה מקבלת מושב
        // טענת יציאה: הפעולה מדפיסה את מספר המשק ושם המשק שאין להם עצי פרי
        public static void NoneTrees(Town T)
        {
            for (int i = 0; i < T.GetNumOfFarms(); i++)
            {
                if (T.GetAllFarms()[i].GetNumOfTrees() == 0)
                {
                    Console.WriteLine("Farm Owner Name: " + T.GetAllFarms()[i].GetOwnerFarmName() + "    " + "Farm Owner Code: " + T.GetAllFarms()[i].GetOwnerFarmCode());
                }
            }

        }

        //// טענת כניסה: המקבלת מערך של 10 מושבים ועץ 
        //// טענת יציאה: מחזירה את סהכ הפירות שנקטפו מהמעץ מכל המשקים ביחד
        //public static int AllFruitsGetPicked(Town[] TownARR, Tree T)
        //{
        //    int Sum = 0;
        //    for (int i = 0; i < TownARR.Length; i++)
        //    {
        //        for (int J = 0; J < TownARR[J].GetAllFarms().Length; J++)
        //        {
        //            Sum += T.GetTreeCountPicked();

        //        }
        //    }
        //    return Sum;
        //}

        // טענת כניסה: המקבלת מערך של 10 מושבים ועץ 
        // טענת יציאה: מחזירה את סהכ הפירות שנקטפו מהמעץ מכל המשקים ביחד
        public static int AllFruitsGetPicked(Town[] TownARR, Tree T)
        {
            int Sum = 0;
            TownARR = new Town[10];
            for (int i = 0; i < TownARR[i].GetAllFarms().Length; i++)
            {
                Sum += T.GetTreeCountPicked();
            }
            return Sum;
        }

        static void Main(string[] args)
        {
            Tree T1 = new Tree("Alon", 1232, 70);
            Tree T2 = new Tree("Oren", 1435, 120);
            Tree T3 = new Tree("Dekel", 1532, 182);
            Tree T4 = new Tree("Shekma", 1235, 0);
            Tree T5 = new Tree("Livna Refuit", 1425, 0);
            Tree T6 = new Tree("Zait", 2467, 0);
            Tree T7 = new Tree("Zait", 2467, 255);

            Farm F1 = new Farm("Evyatar", 9898);
            F1.AddTree(T1);
            F1.AddTree(T2);
            F1.AddTree(T3);

            Farm F2 = new Farm("Adir", 7498);
            F2.AddTree(T4);
            F2.AddTree(T5);
            F2.AddTree(T6);


            Town Town1 = new Town("Or Yehuda");
            Town1.AddFarm(F1);
            Town1.AddFarm(F2);

            Farm F4 = new Farm("cris", 9888);
            F4.AddTree(T1);
            F4.AddTree(T2);
            F4.AddTree(T3);

            Farm F3 = new Farm("ice ", 7488);
            F3.AddTree(T4);
            F3.AddTree(T5);
            F3.AddTree(T6);


            Town Town2 = new Town("Or Yam");
            //Town2.AddFarm(F3);
            //Town2.AddFarm(F4);
            //Town2.AddFarm(F2);


            Town[] AllTowns = { Town1, Town2 };

            Console.WriteLine(Town1);
            Console.WriteLine("````````");
            NoneTrees(Town2);
            Console.WriteLine("All Fruits Get Picked: " + AllFruitsGetPicked(AllTowns, T6));

        }
    }
}
