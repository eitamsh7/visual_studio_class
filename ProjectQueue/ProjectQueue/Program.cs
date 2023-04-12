using System;

namespace ProjectQueue
{
    class Program
    {
        // טענת כניסה: הפעולה מקבלת תור של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה את סכום ערכי האיברים בה
        public static int SumQueue(Queue<int> Q)
        {
            Queue<int> CopyQ = Q.CopyQueue();
            int Sum = 0;
            while (!CopyQ.IsEmpty())
            {
                Sum += CopyQ.Remove();
            }
            return Sum;
        }

        // טענת כניסה: הפעולה מקבלת תור של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה את כמות האיברים בה
        public static int TotalQueue(Queue<int> Q)
        {
            Queue<int> CopyQ = Q.CopyQueue();
            int Total = 0;
            while (!CopyQ.IsEmpty())
            {
                Total++;
                CopyQ.Remove();
            }
            return Total;
        }

        // טענת כניסה: הפעולה מקבלת תור ומספר
        // טענת יציאה: הפעולה בודקת אם המספר נמצא בתור
        public static bool IsExistQueue(Queue<int> Q, int Num)
        {
            Queue<int> CopyQ = Q.CopyQueue();
            while (!CopyQ.IsEmpty())
            {
                if (CopyQ.Remove() == Num)
                    return true;
            }
            return false;
        }

        // טענת כניסה: הפעולה מקבלת תור ומספר
        // טענת יציאה: הפעולה מחזריה כמה פעמים המספר נמצא בתור
        public static int CountNumQueue(Queue<int> Q, int Num)
        {
            Queue<int> CopyQ = Q.CopyQueue();
            int Count = 0;
            while (!CopyQ.IsEmpty())
            {
                if (CopyQ.Remove() == Num)
                    Count++;
            }
            return Count;
        }

        // טענת כניסה: הפעולה מקבלת תור ומספר
        // טענת כניסה: הפעולה מוחקת על אותו התור את כל המופעים של המספר בתור
        public static Queue<int> RemoveNumQueue(Queue<int> Q, int Num)
        {
            Queue<int> CopyQ = Q.CopyQueue();
            Queue<int> TempQ = new Queue<int>();
            while (!CopyQ.IsEmpty())
            {
                if (CopyQ.Head() != Num)
                    TempQ.Insert(CopyQ.Head());
                CopyQ.Remove();
            }
            return TempQ;
        }

        // טענת כניסה: הפעולה מקבלת תור של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה את אותו התור הפוך
        public static Queue<int> ReverseQueue(Queue<int> Q)
        {
            Queue<int> CopyQ = Q.CopyQueue();
            Queue<int> TempQ = new Queue<int>();
            Stack<int> TempS = new Stack<int>();
            while (!CopyQ.IsEmpty())
            {
                TempS.Push(CopyQ.Remove());
            }
            while (!TempS.IsEmpty())
            {
                TempQ.Insert(TempS.Pop());
            }
            return TempQ;
        }

        // טענת כניסה: הפעולה מקבלת תור גנרי
        // טענת יציאה: הפעולה מחזירה את אותו התור הפוך - גנרי
        public static Queue<T> ReverseQueueGeneric<T>(Queue<T> Q)
        {
            Queue<T> CopyQ = Q.CopyQueue();
            Queue<T> TempQ = new Queue<T>();
            Stack<T> TempS = new Stack<T>();
            while (!CopyQ.IsEmpty())
            {
                TempS.Push(CopyQ.Remove());
            }
            while (!TempS.IsEmpty())
            {
                TempQ.Insert(TempS.Pop());
            }
            return TempQ;
        }

        // בגרות 2019 שאלה 5
        //פעולה מקבלת תור של מספרים 
        //פעולה מחזירה את המספר הבנוי מהמספרים שבתוך התור
        public static int ToNumber(Queue<int> Q)
        {
            Queue<int> ReverseQ = ReverseQueue(Q);
            int num = 0;
            while (!ReverseQ.IsEmpty())
                num = (num * 10) + ReverseQ.Remove();
            return num;
        }

        public static int BigNumber(Node<Queue<int>> LstQ)
        {
            Node<Queue<int>> PosL = LstQ;
            int Maximum = ToNumber(PosL.GetValue());
            PosL = PosL.GetNext();
            while (PosL != null)
            {
                if (Maximum < ToNumber(PosL.GetValue()))
                    Maximum = ToNumber(PosL.GetValue());
                PosL = PosL.GetNext();
            }
            return Maximum;
        }

        // שאלת בגרות בתור - 2021 מועד נבצרים שאלה 6

        // פעולת עזר המקבלת תור וקוד של עיר ומחזירה את כמות החולים בכל עיר
        public static int CityCountSick(Queue<CovidTest> Q, int CityCode)
        {
            Queue<CovidTest> CopyQ = Q.CopyQueue();
            int Count = 0;
            while (!CopyQ.IsEmpty())
            {
                if (CopyQ.Head().GetCityCode() == CityCode && CopyQ.Head().GetSick() == true)
                    Count++;
                CopyQ.Remove();
            }
            return Count;
        }

        // הפעולה עצמה
        public static int MostSick(Queue<CovidTest> Q)
        {
            Queue<CovidTest> CopyQ = Q.CopyQueue();
            int MaxSick = 0; // כמות החולים הגבוהה ביותר בכל עיר
            int MaxSickCityCode = 0; // קוד העיר שיש בה את כמות החולים הגבוהה ביותר
            while (!CopyQ.IsEmpty())
            {
                if (CityCountSick(CopyQ, CopyQ.Head().GetCityCode()) > MaxSick)
                {
                    MaxSick = CityCountSick(CopyQ, CopyQ.Head().GetCityCode());
                    MaxSickCityCode = CopyQ.Head().GetCityCode();
                }
                CopyQ.Remove();
            }
            return MaxSickCityCode;
        }


        // שאלת בגרות בתור - 2021 שאלה 7
        // סעיף א
        public static bool IsIdentical(Queue<int> Q1, Queue<int> Q2)
        {
            Queue<int> CopyQ1 = Q1.CopyQueue();
            Queue<int> CopyQ2 = Q2.CopyQueue();
            while(!CopyQ1.IsEmpty() && !CopyQ2.IsEmpty())
            {
                if (CopyQ1.Head() != CopyQ2.Head())
                    return false;
                CopyQ1.Remove();
                CopyQ2.Remove();
            }
            if (CopyQ1.IsEmpty() && CopyQ2.IsEmpty())
                return true;
            return false;
        }
        // סעיף ב
        // פעולת עזר לסעיף ב - הפעולה מבצעת איטרציה אחת של - העברה מההתחלה לסוף
        public static void CircularMove(Queue<int> Q)
        {
            if(!Q.IsEmpty())
                Q.Insert(Q.Remove());
        }
        // פעולת עזר נוספת לסעיף ב - הפעולה סופרת את אורך התור ומחזירה אותו
        public static int CountQ(Queue<int> Q)
        {
            Queue<int> CopyQ = Q.CopyQueue();
            int Count = 0;
            while (!CopyQ.IsEmpty())
            {
                Count++;
                CopyQ.Remove();
            }
            return Count;
        }
        // הפעולה עצמה של סעיף ב
        public static bool IsSimilar(Queue<int> Q1, Queue<int> Q2)
        {
            Queue<int> CopyQ1 = Q1.CopyQueue();
            Queue<int> CopyQ2 = Q2.CopyQueue();
            for (int i = 0; i < CountQ(CopyQ1); i++)
            {
                if (IsIdentical(CopyQ1, CopyQ2))
                    return true;
                CircularMove(CopyQ1);
            }
            return false;
        }


        // שאלת בגרות 2017 מועד א שאלה 1
        public static int Big(int[] Arr)
        {
            int Max = Arr[0];
            int Index = 0;
            for (int i = 1; i < Arr.Length; i++)
            {
                if (Max < Arr[i])
                {
                    Max = Arr[i];
                    Index = i;
                }
            }
            return Index;
        }

        // שאלת בגרות בתור - 2006 שאלה 1
        // סעיף א

        // פעולת עזר
        // טענת כניסה: הפעולה מקבלת תור ומספר
        // טענת יציאה: הפעולה מחזריה כמה פעמים המספר נמצא בתור
        public static int CountFreqNumInQueue(Queue<int> Q, int Num)
        {
            Queue<int> CopyQ = Q.CopyQueue(); // O(n)
            int Count = 0;
            while (!CopyQ.IsEmpty()) // O(n)
            {
                if (CopyQ.Remove() == Num)
                    Count++;
            }
            return Count;
        }
        // פעולת עזר נוספת
        // טענת כניסה: הפעולה מקבלת תור ומספר
        // טענת כניסה: הפעולה מוחקת על אותו התור את כל המופעים של המספר בתור
        public static void RemoveNumFromQueue(Queue<int> Q, int Num)
        {
            Queue<int> TempQ = new Queue<int>();
            while (!Q.IsEmpty()) // O(n)
            {
                if (Q.Head() != Num)
                    TempQ.Insert(Q.Head());
                Q.Remove();
            }
            while (!TempQ.IsEmpty()) // O(n)
            {
                Q.Insert(TempQ.Remove());
            }
        }
        // הפעולה עצמה
        // טענת כניסה: הפעולה מקבלת תור
        // טענת יציאה: הפעולה מחזירה תור של שכיחויות
        public static Queue<int> ReturnFreqQueue(Queue<int> Q)
        {
            Queue<int> CopyQ = Q.CopyQueue(); // O(n)
            Queue<int> NewQ = new Queue<int>();
            while (!CopyQ.IsEmpty()) // O(n)
            {
                NewQ.Insert(CopyQ.Head());
                NewQ.Insert(CountFreqNumInQueue(CopyQ, CopyQ.Head())); // O(n)
                RemoveNumFromQueue(CopyQ, CopyQ.Head()); // O(n)
            }
            return NewQ;
        }

        // סעיף ב

        // O(n^2) סיבוכיות זמן הריצה של האלגוריתם היא
        // n = מספר האיברים בתור

        // האלגוריתם מתחיל בהעתקת התור לתור חדש, באמצעות פעולה שעוברת
        // O(n) על כל איבר בתור פעם אחת בלבד ויעילותה 
        // :לאחר מכן, עבור כל איטרציה של הלולאה

        // ,אנו משתמשים פעם אחת בפעולה שסופרת את מספר המופעים של מספר מסויים בתור
        // מתחילה בהעתקת התור לתור חדש, ואז עוברת על כל איבר בתור פעם אחת בלבד והיעילות
        // O(n) + O(n) = O(2n) = O(n)
        // אחר כך, אנו משתמשים פעם אחת בפעולה המוחקת את המופעים
        // של מספר מסויים מהתור, ועוברת על כל איבר בתור פעמיים
        // O(n) + O(n) = O(2n) = O(n)

        // =>

        // לולאה חיצונית
        // O(n)

        // בתוך הלולאה
        // O(n) + O(n) = O(2n) = O(n)

        // לכן סך הכל
        // O(n) * O(n) = = O(n*n) O(n^2)


        static void Main(string[] args)
        {
            Queue<int> Q1 = new Queue<int>();
            Q1.Insert(8);
            Q1.Insert(4);
            Q1.Insert(6);
            Q1.Insert(8);
            Q1.Insert(2);
            Q1.Insert(1);
            Q1.Insert(8);
            Q1.Insert(7);
            Q1.Insert(9);

            // פעולות ראשוניות
            //Console.WriteLine(SumQueue(Q1));
            //Console.WriteLine(TotalQueue(Q1));
            //Console.WriteLine(IsExistQueue(Q1, 4));
            //Console.WriteLine(CountNumQueue(Q1, 8));
            //Console.WriteLine(RemoveNumQueue(Q1, 7));
            //Console.WriteLine(ReverseQueue(Q1));
            //Console.WriteLine(ReverseQueueGeneric(Q1));

            Queue<int> Q2 = new Queue<int>();
            Q2.Insert(2);
            Q2.Insert(6);

            Queue<int> Q3 = new Queue<int>();
            Q3.Insert(7);
            Q3.Insert(2);
            Q3.Insert(4);

            Queue<int> Q4 = new Queue<int>();
            Q4.Insert(2);
            Q4.Insert(8);

            Queue<int> Q5 = new Queue<int>();
            Q5.Insert(1);
            Q5.Insert(9);
            Q5.Insert(6);

            // בגרות 2019 שאלה 5
            Node<Queue<int>> L1 = new Node<Queue<int>>(Q2);
            Node<Queue<int>> Pos1 = L1;
            Pos1.SetNext(new Node<Queue<int>>(Q3));
            Pos1 = Pos1.GetNext();
            Pos1.SetNext(new Node<Queue<int>>(Q4));
            Pos1 = Pos1.GetNext();
            Pos1.SetNext(new Node<Queue<int>>(Q5));
            Pos1 = Pos1.GetNext();

            //Console.WriteLine(BigNumber(L1));

            // שאלת בגרות בתור - 2021 מועד נבצרים שאלה 6
            Queue<CovidTest> Q6 = new Queue<CovidTest>();
            Q6.Insert(new CovidTest("Shimon", "1357", 15, true));
            Q6.Insert(new CovidTest("Tal", "2468", 14, true));
            Q6.Insert(new CovidTest("Evia", "215666", 15, true));
            Q6.Insert(new CovidTest("AmirGay", "21569", 14, true));
            Q6.Insert(new CovidTest("Liam", "215789", 15, false));
            Q6.Insert(new CovidTest("Hen", "1691", 15, true));

            //Console.WriteLine(MostSick(Q6));

            // שאלת בגרות בתור - 2021 שאלה 7
            Queue<int> Q7 = new Queue<int>();
            Q7.Insert(1);
            Q7.Insert(2);
            Q7.Insert(3);
            Q7.Insert(4);

            Queue<int> Q8 = new Queue<int>();
            Q8.Insert(3);
            Q8.Insert(4);
            Q8.Insert(1);
            Q8.Insert(2);

            //Console.WriteLine(IsSimilar(Q7, Q8));
        }
    }
}
