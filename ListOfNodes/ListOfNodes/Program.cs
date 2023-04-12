using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ListOfNodes
{
    class Program
    {
        // N בנייה של שרשרת חוליות, הפעולה מקבלת את מספר החוליות 
        // הפעולה תחזיר שרשרת חוליות
        // למעשה, הפעולה מחזירה את ההפניה\כתובת של החוליה הראשונה
        // ההוספה של החוליה החדשה תהיה לסוף השרשרת
        public static Node<int> AddToLast(int N)
        {
            Node<int> L = null;
            Node<int> PosL = null;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Enter a Value: ");
                int Num = int.Parse(Console.ReadLine());
                if (L == null)
                {
                    L = new Node<int>(Num);
                    PosL = L;
                }
                else
                {
                    PosL.SetNext(new Node<int>(Num));
                    PosL = PosL.GetNext();
                }
            }
            return L;
        }

        // הפעולה מקבלת שרשרת חוליות ומדפיסה את הערכים שלה
        public static void PrintList(Node<int> L)
        {
            Node<int> PostL = L;
            while (PostL != null)
            {
                Console.Write(PostL + " , ");
                PostL = PostL.GetNext();
            }
        }

        // הפעולה מקבלת שרשרת של מספרים שלמים
        // הפעולה תחזיר את סכום הערכים בה
        public static int SumList(Node<int> L)
        {
            int Sum = 0;
            Node<int> PosL = L;
            while (PosL != null)
            {
                Sum += PosL.GetValue();
                PosL = PosL.GetNext();
            }
            return Sum;
        }

        // הפעולה מקבלת שרשרת של מספרים שלמים ומחזירה את הערך המקסימלי
        public static int FindMax(Node<int> L)
        {
            int Max = L.GetValue();
            Node<int> PosL = L;
            while (PosL != null)
            {
                if (PosL.GetValue() > Max)
                    Max = PosL.GetValue();
            }
            return Max;
        }

        // הפעולה מקבלת שרשרת חוליות ומחזירה אמת או שקר אם השרשרת בסדר עולה
        public static bool IsSorted(Node<int> L)
        {
            Node<int> PosL = L;
            if (L == null)
                return false;
            while (PosL.GetNext() != null)
            {
                if (PosL.GetValue() > PosL.GetNext().GetValue())
                    return false;
                PosL = PosL.GetNext();
            }
            return true;
        }

        // הפעולה מקבלת שרשרת של מספרים שלמים ומספר, הפעולה מחזירה אמת אם המספר נמצא בתוך השרשרת, אחרת שקר
        public static bool IsExist(Node<int> L, int N)
        {
            Node<int> PosL = L;
            while (PosL != null)
            {
                if (PosL.GetValue() == N)
                    return true;
                PosL = PosL.GetNext();
            }
            return false;
        }

        //הפעולה מקבלת שרשרת חוליות ומספר שלם
        //הפעולה מחזירה שרשרת חדשה ללא המספר שנקלטת. וללא כפילויות של שאר המספרים
        public static Node<int> RemoveNum(Node<int> L, int Num)
        {
            Node<int> NewL = null;
            Node<int> PosNewL = null;
            Node<int> PosL = L;
            while (PosL != null)
            {
                if (PosL.GetValue() != Num && !IsExist(NewL, PosL.GetValue()))
                {
                    if (NewL == null)
                    {
                        NewL = new Node<int>(PosL.GetValue());
                        PosNewL = NewL;
                    }
                    else
                    {
                        PosNewL.SetNext(new Node<int>(PosL.GetValue()));
                        PosNewL = PosNewL.GetNext();
                    }
                }
                PosL = PosL.GetNext();
            }
            return NewL;
        }

        //  הפעולה מקבלת שרשרת חוליות ומספר ומחזירה שרשרת ממויינת עם המספר שקיבלנו בפנים
        public static Node<int> InsertX(Node<int> L, int X)
        {
            if (L == null || X < L.GetValue())
            {
                L = new Node<int>(X, L);
                return L;
            }
            Node<int> PosL = L;
            while (PosL.GetNext() != null && X > PosL.GetNext().GetValue())
            {
                PosL = PosL.GetNext();
            }
            PosL.SetNext(new Node<int>(X, PosL.GetNext()));
            return L;
        }

        // הפעולה מקבלת שרשת לא ממויינת וממיינת אותה באמצעות הפעולה שרשמנו בתרגיל הקודם
        public static Node<int> SortedList(Node<int> L)
        {
            Node<int> PosL = L;
            Node<int> NewL = null;
            while (PosL != null)
            {
                NewL = InsertX(L, L.GetNext().GetValue());
                PosL = PosL.GetNext();
            }
            return NewL;
        }

        // הפעולה מקבלת שרשרת חוליות ומספר ומחזירה את אותה שרשרת ללא הופעות של מהספר שקיבלנו
        public static Node<int> DeleteNodes(Node<int> L, int Num)
        {
            Node<int> PosL = L;
            Node<int> PrevPos = null;
            while (PosL != null)
            {
                if (PosL.GetValue() == Num)
                {
                    if (PrevPos == null)
                    {
                        L = L.GetNext();
                        PosL = L;
                    }
                    else
                    {
                        PrevPos.SetNext(PosL.GetNext());
                        PosL = PosL.GetNext();
                    }
                }
                else
                {
                    PrevPos = PosL;
                    PosL = PosL.GetNext();
                }
            }
            return L;
        }

        // בניית שרשרת חוליות. הוספת חוליות לתחילת השרשרת
        // הפעולה מקבלת מספר שלם חיובי המציין את מספר החוליות שרוצים לבנות
        public static Node<int> AddToFirst(int Num)
        {
            Node<int> L = null;
            for (int i = 0; i < Num; i++)
            {
                Console.WriteLine("ENTER THE VALUE");
                int input = int.Parse(Console.ReadLine());
                L = new Node<int>(input, L);
            }
            return L;
        }

        // פעולה מקבלת שרשרת חוליות
        // הפעולה מחזירה שרשרת חוליו שבתוכם יש רצפים
        // בגרות 2010
        public static Node<Range> CreateRangeList(Node<int> L)
        {
            Node<int> PosL = L;
            Node<Range> NewL = null;
            Node<Range> PosNewL = null;
            int From = 0;
            if (L != null)
            {
                From = L.GetValue();
            }
            Range R;
            while (PosL.GetNext() != null)
            {
                if (PosL.GetValue() + 1 != PosL.GetNext().GetValue())
                {
                    R = new Range(From, PosL.GetValue());
                    if (NewL == null)
                    {
                        NewL = new Node<Range>(R);
                        PosNewL = NewL;
                    }
                    else
                    {
                        PosNewL.SetNext((new Node<Range>(R)));
                        PosNewL = PosNewL.GetNext();
                    }
                    From = PosL.GetNext().GetValue();
                }
                PosL = PosL.GetNext();
            }

            R = new Range(From, PosL.GetValue());
            if (NewL == null)
            {
                NewL = new Node<Range>(R);
                PosNewL = NewL;
            }
            else
            {
                PosNewL.SetNext((new Node<Range>(R)));
                PosNewL = PosNewL.GetNext();
            }
            return NewL;
        }

        // טענת כניסה: הפעולה מקבלת שרשרת של שלמים
        // טענת יציאה: הפעולה מחזירה את אותה שרשרת כך שהמספרים הזוגיים בהתחלה והאי זוגיים אחרי- הסדר בתוכם לא משנה
        public static Node<int> EvenThanOdd(Node<int> L)
        {
            Node<int> PoseL = L;
            if (L == null)
                return L;
            while (PoseL.GetNext() != null)
            {
                if (PoseL.GetNext().GetValue() % 2 == 0)
                {
                    L = new Node<int>(PoseL.GetNext().GetValue(), L);
                    PoseL.SetNext(PoseL.GetNext().GetNext());

                }
                else
                {
                    PoseL = PoseL.GetNext();
                }
            }
            return L;

        }

        // הפעולה מקבלת שרשרת של מספרים שלמים
        // הפעולה תחזיר את מספר הערכים בה
        public static int CountNodes(Node<int> L)
        {
            int Count = 0;
            Node<int> PosL = L;
            while (PosL != null)
            {
                Count++;
                PosL = PosL.GetNext();
            }
            return Count;
        }

        // טענת כניסה: שרשרת חוליות של שלמים
        // טענת יציאה: הפעולה תחזיר אמת אם השרשרת משולשת
        // בגרות 2016 מועד ב - שאלה 1
        public static bool IsTriange(Node<int> L)
        {
            int X = CountNodes(L);
            if (L == null || X % 3 != 0)
                return false;
            Node<int> PoseL1 = L;
            Node<int> PoseL2 = L;
            for (int i = 0; i < X / 3; i++)
            {
                PoseL2 = PoseL2.GetNext();
            }
            Console.WriteLine(PoseL2.GetValue());
            while (PoseL2 != null)
            {
                if (PoseL1.GetValue() != PoseL2.GetValue())
                    return false;
                PoseL1 = PoseL1.GetNext();
                PoseL2 = PoseL2.GetNext();
            }
            return true;
        }

        // הפעולה מקבלת שתי חוליות
        // הפעולה מחזירה שרשרת חוליות חדשה משולבת על ידי שתי השרשראות 
        // על פי התנאים
        public static Node<int> Bagrut2006Q4(Node<int> L1, Node<int> L2)
        {
            Node<int> PosL1 = L1;
            Node<int> PosL2 = L2;
            Node<int> L3 = null;
            while (PosL1 != null)
            {
                PosL2 = L2;
                int K = PosL1.GetValue();
                if (K <= CountNodes(L2))
                {
                    for (int i = 1; i < K - 1; i++)
                    {
                        PosL2 = PosL2.GetNext();
                    }
                    //Console.WriteLine(PosL2.GetValue());
                    if (K % 2 == 0)
                    {
                        PosL2.SetNext(PosL2.GetNext().GetNext());
                    }
                    else
                    {
                        L3 = new Node<int>(PosL2.GetNext().GetValue(), L3);
                    }
                }
                PosL1 = PosL1.GetNext();
            }
            return L3;
        }

        // כתוב פעולה חיצונית המקבלת שרשרת של מספרים חד ספרתיים שלמים
        // הפעולה מחזירה שרשרת מספרים חדשים מכל הספרות
        // כל מספר מורכב מהספרות עד למינוס 9
        public static Node<int> NumsUntilMinusNine(Node<int> L)
        {
            int Sum = 0;
            Node<int> PosL = L;
            Node<int> newL = null;
            Node<int> PosnewL = newL;
            if (L == null)
                return L;
            if (L.GetValue() != -9 && L.GetNext() == null)
                return L;
            while (PosL != null)
            {
                if(PosL.GetValue() != -9)
                {
                    if (Sum == 0)
                        Sum = PosL.GetValue();
                    else
                        Sum = Sum * 10 + PosL.GetValue();
                }
                else if (Sum != 0)
                {
                    if (newL != null)
                    {
                        PosnewL.SetNext(new Node<int>(Sum));
                        PosnewL = PosnewL.GetNext();
                    }
                    else
                    {
                        newL = new Node<int>(Sum);
                        PosnewL = newL;
                    }
                    Sum = 0;
                }
                PosL = PosL.GetNext();
            }
            if (Sum != 0)
            {
                PosnewL.SetNext(new Node<int>(Sum));
                PosnewL = PosnewL.GetNext();
            }
            return newL;
        }

        // שאלת בגרות אוגוסט 2020
        // טענת כניסה: הפועלה מקבלת שרשרת חוליות
        // טענת יציאה: הפעולה תחזיר שרשרת ספרות המייצגת את המספרת שבשרשרת מספרים חיובים
        // הנחה שנתנו לנו: השרשרת אינה ריקה
        // -9 שרשרת ספרות היא שרשרת של הספרות כך שהאחדות מופיעות ואז עשרות ומאות וכו ובינהם מפריד 
        // שרשרת מספרים חיובים היא שרשרת מספרים חיובים
        public static Node<int> DigitsList(Node<int> L)
        {
            Node<int> PosL = L;
            Node<int> NewL = null;
            Node<int> PosNewL = NewL;

            while (PosL != null)
            {
                int Temp = PosL.GetValue();
                while (Temp > 0)
                {
                    if (NewL == null)
                    {
                        NewL = new Node<int>(Temp % 10);
                        PosNewL = NewL;
                    }
                    else
                    {
                        PosNewL.SetNext(new Node<int>(Temp % 10));
                        PosNewL = PosNewL.GetNext();
                    }
                    Temp /= 10;
                }
                PosNewL.SetNext(new Node<int>(-9)); // New L is already exist because the list has at leat 1 positive number
                PosNewL = PosNewL.GetNext();
                PosL = PosL.GetNext();
            }

            return NewL;
        }

        // פעולת הדפסה גנרית
        public static void PrintListGeneric<T>(Node<T> L)
        {
            Node<T> Pos = L;
            while (Pos != null)
            {
                Console.Write(Pos + " ");
                Pos = Pos.GetNext();
            }
            Console.WriteLine();
        }

      

        static void Main(string[] args)
        {
            //Console.WriteLine("Enter Num of Nodes: ");
            //int N = int.Parse(Console.ReadLine());
            //Node<int> L = AddToLast(N);
            //PrintList(L);
            //Console.WriteLine();
            //Node<int> NewL = RemoveNum(L, 3);
            //PrintList(NewL);
            //
            Node<int> L1 = new Node<int>(4);
            Node<int> Pos1 = L1;
            Pos1.SetNext(new Node<int>(3));
            Pos1 = Pos1.GetNext();
            Pos1.SetNext(new Node<int>(2));
            Pos1 = Pos1.GetNext();
            Pos1.SetNext(new Node<int>(6));

            ////Node<int> L2 = new Node<int>(10);
            ////Node<int> Pos2 = L2;
            ////Pos2.SetNext(new Node<int>(11));
            ////Pos2 = Pos2.GetNext();
            ////Pos2.SetNext(new Node<int>(19));
            ////Pos2 = Pos2.GetNext();
            ////Pos2.SetNext(new Node<int>(1));
            ////Pos2 = Pos2.GetNext();
            ////Pos2.SetNext(new Node<int>(7));
            ////Pos2 = Pos2.GetNext();
            ////Pos2.SetNext(new Node<int>(100));


            //PrintList(L1);
            //Console.WriteLine();
            //DeleteNodes(L1, 4);
            //PrintList(L1);
            ////PrintList(Bagrut2006Q4(L1, L2));

            //Node<int> L2 = new Node<int>(1);
            //Node<int> Pos2 = L2;
            //Pos2.SetNext(new Node<int>(8));
            //Pos2 = Pos2.GetNext();
            //Pos2.SetNext(new Node<int>(7));
            //Pos2 = Pos2.GetNext();
            //Pos2.SetNext(new Node<int>(-9));
            //Pos2 = Pos2.GetNext();
            //Pos2.SetNext(new Node<int>(8));
            //Pos2 = Pos2.GetNext();
            //Pos2.SetNext(new Node<int>(-9));
            //Pos2 = Pos2.GetNext();
            //Pos2.SetNext(new Node<int>(7));
            //Pos2 = Pos2.GetNext();
            //Pos2.SetNext(new Node<int>(-9));
            //Pos2 = Pos2.GetNext();
            //Pos2.SetNext(new Node<int>(4));
            //Pos2 = Pos2.GetNext();

            //PrintList(NumsUntilMinusNine(L2));

            // Stations - BusRoute
            Station S1 = new Station(0, 2);
            Station S2 = new Station(1, 4);
            Station S3 = new Station(5, 4);
            Station S4 = new Station(3, 1);
            Station S5 = new Station(5, 0);
            BusRoute Br1 = new BusRoute(S1, S2);
            Br1.AddStation(S3);
            Br1.AddStation(S4);
            Br1.AddStation(S5);
            //Console.WriteLine(Br1);
            //Console.WriteLine(Br1.RouteLen());

            //יצירת שרשרת חוליות
            Node<int> L6 = new Node<int>(92);
            Node<int> PosL6 = L6;
            PosL6.SetNext(new Node<int>(4));
            PosL6 = PosL6.GetNext();
            PosL6.SetNext(new Node<int>(543));
            PosL6 = PosL6.GetNext();

            // שאלת בגרות 2020
            // שרשרת של ספרות ממספרים שלמים חיוביים
            // -9 המפרדים על ידי 
            //Console.WriteLine();
            //Console.WriteLine("============================");
            //PrintList(L6);
            //Console.WriteLine();
            //PrintList(DigitsList(L6));

            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // Birthday, AllBirthday:
            AllBirthday Birthdays = new AllBirthday();
            Birthday B1 = new Birthday("Yair", 69);
            Birthday B2 = new Birthday("Eitam", 24);
            Birthday B3 = new Birthday("Evyatar", 78);
            Birthdays.AddBirthday(B1, 12);
            Birthdays.AddBirthday(B2, 10);
            Birthdays.AddBirthday(B3, 10);
            Console.WriteLine(Birthdays.ToString());
            Console.WriteLine(Birthdays.MaxBirthday());
            Console.WriteLine();
            Birthdays.RemoveBirthday(B3, 11);
            Console.WriteLine(Birthdays.ToString());

        }
    }
}

