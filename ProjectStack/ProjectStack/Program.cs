using System;

namespace ProjectStack
{
    class Program
    {
        // טענת כניסה: הפעולה מקבלת מחסנית של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה העתק של המחסנית שקיבלנו ומשאירה את המחסנית שקיבלנו כפי שההיא
        public static Stack<int> CopyStack(Stack<int> S)
        {
            Stack<int> TempS = new Stack<int>();
            Stack<int> NewS = new Stack<int>();
            while (!S.IsEmpty())
            {
                TempS.Push(S.Pop());
            }
            while (!TempS.IsEmpty())
            {
                S.Push(TempS.Top());
                NewS.Push(TempS.Pop());
            }
            return NewS;
        }

        // טענת כניסה: כתוב פעולה חיצונית המקבלת מחסנית של שלמים ומספר שלם
        // טענת יציאה: הפעולה מחזירה נכון אם המספר נמצא במחסנית אחרת לא נכון- חובה לשמור על המסנית המקורית
        public static bool IsExist(Stack<int> S, int Num)
        {
            Stack<int> TempS = CopyStack(S);
            while (!TempS.IsEmpty())
            {
                if (TempS.Top() == Num)
                    return true;
                TempS.Pop();
            }
            return false;
        }

        // סכום ערכים במחסנית
        // טענת כניסה: הפעולה מקבלת מחזנית של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה את סכום האיברים במחסנית
        public static int SumStack(Stack<int> S)
        {
            Stack<int> tempS = new Stack<int>();
            int Sum = 0;
            while (!S.IsEmpty())
            {
                Sum += S.Top();
                tempS.Push(S.Pop());
            }
            while (!tempS.IsEmpty())
            {
                S.Push(tempS.Pop());
            }
            return Sum;
        }

        // טענת כניסה: כתוב פעולה חיצונית המקבלת מחסנית של שלמים
        // טענת יציאה: הפעולה תחזיר את המספר הקטן ביותר - חובה לשמור על המחסנית המקורית
        public static int Min(Stack<int> S)
        {
            Stack<int> TempS = CopyStack(S);
            int Min = TempS.Pop();
            while (!TempS.IsEmpty())
            {
                if (TempS.Top() < Min)
                    Min = TempS.Top();
                TempS.Pop();
            }
            return Min;
        }

        // טענת כניסה: הפעולה מקבלת של שלמים ומספר שלם
        // טענת יציאה: הפעולה מחזירה כמה פעמים המספר מופיע במחסנית - חובה לשמור על המחסנית המקורית
        public static int CountNum(Stack<int> S, int Num)
        {
            Stack<int> TempS = CopyStack(S);
            int Count = 0;
            while (!TempS.IsEmpty())
            {
                if (TempS.Top() == Num)
                    Count++;
                TempS.Pop();
            }
            return Count;
        }

        // טענת כניסה: הפעולה מקבלת מחסנית של שלמים ומספר שלם
        // טענת יציאה: הפעולה מוחקת את כל ההופעות של המספר מהמחסנית
        public static void RemoveNum(Stack<int> S, int Num)
        {
            Stack<int> TempS = new Stack<int>();
            while (!S.IsEmpty())
            {
                if (S.Top() == Num)
                    S.Pop();
                else
                    TempS.Push(S.Pop());
            }
            while (!TempS.IsEmpty())
            {
                S.Push(TempS.Pop());
            }
        }

        // טענת כניסה: הפעולה מקבלת מחסנית לא ממוינת של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה מחזירה מחסנית חדשה ממוינת - חובה לשמור על המחסנית המקורית
        public static Stack<int> SortStack(Stack<int> S)
        {
            Stack<int> SortS = new Stack<int>();
            Stack<int> TempS = CopyStack(S);
            while (!TempS.IsEmpty())
            {
                int Minimum = Min(TempS);
                int Count = CountNum(TempS, Minimum);
                RemoveNum(TempS, Minimum);
                for (int i = 0; i < Count; i++)
                {
                    SortS.Push(Minimum);
                }
            }
            return SortS;
        }

        // בגרות קיץ  2020 מועד א שאלה 4
        // א
        // טענת כניסה: הפעולה מקבלת מחסנית של שלמים ומספר שלם
        // טענת יציאה: הפעולה תחזיר נכון אם יש במחסנית מספר שספרת האחדות שלו שווה למספר שקיבלנו
        public static bool IsExistA(Stack<int> S, int Num)
        {
            Stack<int> TempS = CopyStack(S);
            while (!TempS.IsEmpty())
            {
                if (TempS.Top() % 10 == Num)
                    return true;
                TempS.Pop();
            }
            return false;
        }

        // ב
        // טענת כניסה: הפעולה מקבלת מחסנית שאינה ריקה מטיפוס שלם
        // טענת יציאה: הפעולה מחזירה אמת אם כל הספרות המשמעותיות במספרים במחסנית הם בספרת היחידות, אחרת שקר
        public static bool AllExistA(Stack<int> S)
        {
            Stack<int> TempS = CopyStack(S);
            while (!TempS.IsEmpty())
            {
                int ImpNum = TempS.Top();
                while (ImpNum > 9)
                    ImpNum = ImpNum / 10;
                if (!IsExistA(S, ImpNum))
                    return false;
                TempS.Pop();
            }
            return true;
        }

        // בגרות קיץ 2020 מועד ב שאלה 5
        // טענת כניסה: הפעולה מקבלת מחסנית מטיפוס שלם
        // טענת יציאה: הפעולה מחזירה מחסנית חדשה שתכיל את כל המספרים שאינם בלוק
        // בלוק במחסנית הוא רצף של לפחות שני איברים זהים
        public static Stack<int> NotBlock(Stack<int> S)
        {
            Stack<int> NotBlockS = new Stack<int>();
            Stack<int> TempS = CopyStack(S);
            int TempNum = TempS.Pop();
            if (S.IsEmpty())
                return NotBlockS;
            while (!TempS.IsEmpty())
            {
                if (TempNum != TempS.Top())
                {
                    NotBlockS.Push(TempNum);
                }
                else
                {
                    int MoreTemp = TempS.Pop();
                    if (MoreTemp == TempS.Top())
                        TempS.Pop();
                }
                TempNum = TempS.Pop();
            }
            NotBlockS.Push(TempNum);
            return NotBlockS;
        }

        // דרך נוספת שטליה טןענת שהיא יותר טובה
        // בגרות קיץ 2020 מועד ב שאלה 5
        public static Stack<int> NoBlock(Stack<int> S)
        {
            Stack<int> NotBlockS = new Stack<int>();
            Stack<int> TempS = CopyStack(S);
            int Count = 1;
            int PrevNum = TempS.Pop();
            if (S.IsEmpty())
                return NotBlockS;
            while (!TempS.IsEmpty())
            {
                if (PrevNum != TempS.Top())
                {
                    if (Count == 1)
                        NotBlockS.Push(PrevNum);
                    Count = 1;
                }
                else
                {
                    Count++;
                }
                PrevNum = TempS.Pop();
            }
            if (Count == 1)
            {
                NotBlockS.Push(PrevNum);
            }
            return NotBlockS;
        }

        // בגרות 2010 שאלה 1
        // טענת כניסה: הפעולה מקבלת שתי מחסניות המכילות מספרים שלמים וגדולים מ-0
        // טענת יציאה: הפעולה תחזיר את הסכום של הזוג איברים הסכומים הקרוב ביותר למחסנית הראשונה
        // שסכומם גדול מהסכום של כל זוג איברים סמוכים במחסנית השנייה
        public static int BiggestPairSum(Stack<int> St1, Stack<int> St2)
        {
            Stack<int> TempS1 = CopyStack(St1);
            Stack<int> TempS2 = CopyStack(St2);
            int FirstTop = TempS2.Pop();
            int MaxPairSum = 0;
            while (!TempS2.IsEmpty())
            {
                int SecondTop = TempS2.Pop();
                if (FirstTop + SecondTop > MaxPairSum)
                    MaxPairSum = FirstTop + SecondTop;
                FirstTop = SecondTop;
            }
            FirstTop = TempS1.Pop();
            while (!TempS1.IsEmpty())
            {
                int SecondTop = TempS1.Pop();
                if (FirstTop + SecondTop > MaxPairSum)
                    return FirstTop + SecondTop;
                FirstTop = SecondTop;
            }
            return 0;
        }

        // פעולת עזר
        // טענת כניסה: מקבלת מחסנית 
        // טענת יציאה: מחזירה שרשרת של שלמים - הפעולה מטפלת כל פעם במחסנית אחת בלבד
        // בונה שרשרת של שלמים שבה כל חולייה בנוייה מהמספרים שהיו במחסנית עד למינוס תשע
        public static Node<int> StackToList(Stack<int> S1)
        {
            int X = -1;
            Stack<int> TempS1 = CopyStack(S1);
            Node<int> newL = null;
            Node<int> PosnewL = newL;
            int NewNum = 0;
            int Mult = 1;
            while (!TempS1.IsEmpty())
            {
                if (TempS1.Top() != -9)
                {
                    NewNum += Mult * TempS1.Top();
                    Mult *= 10;
                }
                else
                {
                    if (newL != null)
                    {
                        PosnewL.SetNext(new Node<int>(NewNum));
                        PosnewL = PosnewL.GetNext();
                    }
                    else
                    {
                        newL = new Node<int>(NewNum);
                        PosnewL = newL;
                    }
                    NewNum = 0;
                    Mult = 1;
                }
                X = TempS1.Pop();
            }
            if (X != -9)
            {
                if (newL != null)
                {
                    PosnewL.SetNext(new Node<int>(NewNum));
                }
                else
                {
                    newL = new Node<int>(NewNum);
                }
            }
            return newL;
        }

        // טענת כניסה: הפעולה מקבלת שרשרת של מחסניות
        // טענת יציאה: הפעולה מחזירה שרשראות שהסדר משנה
        public static Stack<Node<int>> ListToStack(Node<Stack<int>> L)
        {
            Node<Stack<int>> PosL = L;
            Stack<Node<int>> S = new Stack<Node<int>>();
            while (PosL != null)
            {
                Stack<int> ST = PosL.GetValue();
                Node<int> LT = StackToList(ST);
                Node<int> PosLT = LT;
                while (PosLT != null)
                {
                    S.Push(PosLT);
                    PosLT = PosLT.GetNext();
                }
                PosL = PosL.GetNext();
            }
            return S;
        }

        public static Stack<T> CopyStackGeneric<T>(Stack<T> S) // העתקת מחסנית גנרית
        {
            Stack<T> TempS = new Stack<T>();
            Stack<T> NewS = new Stack<T>();
            while (!S.IsEmpty())
            {
                TempS.Push(S.Pop());
            }
            while (!TempS.IsEmpty())
            {
                S.Push(TempS.Top());
                NewS.Push(TempS.Pop());
            }
            return NewS;
        }
        public static void PrintListGeneric<T>(Node<T> L) // הדפסת שרשרת גנרית
        {
            Node<T> PosL = L;
            while (PosL != null)
            {
                Console.Write($"{PosL.GetValue()} ");
                PosL = PosL.GetNext();
            }
        }
        public static void PrintStackListGeneric<T>(Stack<Node<T>> StkL) // הדפסת מחסנית גנרית
        {
            Stack<Node<T>> CopyStkL = CopyStackGeneric(StkL);
            while (!CopyStkL.IsEmpty())
                PrintListGeneric(CopyStkL.Pop());
            Console.WriteLine();
        }

        //טענת כניסה: עולה מקבלת מחסנית 
        //טענת יציאה: פעולה מחזירה את המספר הכי תחתון במחסנית ואת המחסנית בלחי המספר הזה
        public static int LastAndRemove(Stack<int> S)
        {
            Stack<int> NewS = new Stack<int>();
            int num = 0;
            while (!S.IsEmpty())
                NewS.Push(S.Pop());
            num = NewS.Pop();
            while (!NewS.IsEmpty())
                S.Push(NewS.Pop());
            return num;
        }

        // שאלה בגרות 2018 שאלה 4

        // א
        // טענת כניסה: הפעולה מקבלת מחסנית של שלמים באורך זוגי
        // טענת יציאה: הפעולה מחזירה מחסנית מטיפוס 
        // TwoItems
        // איבר מהסוף ואיבר מהתחלה וכן הלאה
        // ךא צריך לשמור על המחסנית
        public static Stack<TwoItems> StackTwoItems(Stack<int> S)
        {
            Stack<TwoItems> STI = new Stack<TwoItems>();
            while (!S.IsEmpty())    
            {
                TwoItems TI = new TwoItems(S.Pop(), LastAndRemove(S));
                STI.Push(TI);
            }
            return STI;
        }

        // ב
        // אותה פעולה, רק שהפעם במחסנית יכולים להיות כמות מספרים זוגית או אי זוגית של מספרים
        public static Stack<TwoItems> StackTwoItems1(Stack<int> S)
        {
            TwoItems TI;
            Stack<TwoItems> STI = new Stack<TwoItems>();
            while (!S.IsEmpty())
            {
                int X = S.Pop();
                if (!S.IsEmpty())
                {
                    TI = new TwoItems(X, LastAndRemove(S));
                }
                else
                {
                    TI = new TwoItems(X, X);                  
                }
                STI.Push(TI);
            }
            return STI;
        }

        // טענת כניזסה: הפעולה מקבלת מחסנית של שלמים ממוינת
        // טענת יציאה: הפעולה מחזירה מחסנית שממלאת את כל ההפרשים במחסנית
        public static Stack<int> FillIn(Stack<int> S)
        {
            Stack<int> CopyS = CopyStack(S);
            Stack<int> TempS = new Stack<int>();
            Stack<int> ReturnS = new Stack<int>();
            while (!CopyS.IsEmpty())
            {
                TempS.Push(CopyS.Pop());
            }
            int FirstTop = TempS.Pop();
            while (!TempS.IsEmpty())
            {
                int SecondTop = TempS.Pop();
                if (FirstTop != SecondTop - 1)
                {
                    for (int i = FirstTop + 1; i < SecondTop; i++)
                    {
                        ReturnS.Push(i);
                    }
                }
                FirstTop = SecondTop;
            }
            return ReturnS;
        }
        // טענת כנסה: הפעולה מקבלת שרשרת של מחסניות ממוינות
        // טענת יציאה: הפעולה מחזירה מחסנית של מחסניות שיהיה בה את כל המספרים החסרים במיון
        public static Stack<Stack<int>> FillRange(Node<Stack<int>> L)
        {
            Stack<Stack<int>> ReturnS = new Stack<Stack<int>>();
            Node<Stack<int>> PosL = L;
            while (PosL != null)
            {
                ReturnS.Push(FillIn(PosL.GetValue()));
                PosL = PosL.GetNext();
            }
            return ReturnS;
        }

        // טענת כניסה: הפעולה מקבלת מחסנית
        // טענת יציאה: הפעולה מדפיסה את אותה מחסנית שקיבלנו רק שהיא מחליפה בין זוגות של האיברים במחסנית - המחסנית מכירה מספר זוגי של איברים
        public static void OppositePairs(Stack<int> S)
        {
            Stack<int> TempS = new Stack<int>();
            while (!S.IsEmpty())
            {
                int FirstTop = S.Pop();
                TempS.Push(S.Pop());
                TempS.Push(FirstTop);
            }
            while (!TempS.IsEmpty())
            {
                S.Push(TempS.Pop());
            }
            Console.WriteLine(S);
        }
        static void Main(string[] args)
        {
            // יצירת מחסניות
            Stack<int> S1 = new Stack<int>();
            Stack<int> S2 = new Stack<int>();
            Stack<int> S3 = new Stack<int>();
            Stack<int> S4 = new Stack<int>();

            S1.Push(1);
            S1.Push(2);
            S1.Push(-9);
            S1.Push(3);
            S1.Push(4);

            S2.Push(5);
            S2.Push(6);
            S2.Push(-9);
            S2.Push(7);
            S2.Push(8);

            S3.Push(1);
            S3.Push(2);
            S3.Push(-9);
            S3.Push(3);
            S3.Push(4);

            S4.Push(5);
            S4.Push(6);
            S4.Push(-9);
            S4.Push(7);
            S4.Push(8);

            //// מימוש
            //Node<Stack<int>> L1 = new Node<Stack<int>>(S1);
            //Node<Stack<int>> Pos1 = L1;
            //Pos1.SetNext(new Node<Stack<int>>(S2));
            //Pos1 = Pos1.GetNext();
            //Pos1.SetNext(new Node<Stack<int>>(S3));
            //Pos1 = Pos1.GetNext();
            //Pos1.SetNext(new Node<Stack<int>>(S4));
            //Pos1 = Pos1.GetNext();

            //PrintListGeneric<Stack<int>>(L1);

            //Console.WriteLine();

            //Console.WriteLine(ListToStack(L1));




            // יצירת מחסניות
            Stack<int> S5 = new Stack<int>();
            Stack<int> S6 = new Stack<int>();
            Stack<int> S7 = new Stack<int>();
            Stack<int> S8 = new Stack<int>();

            S5.Push(20);
            S5.Push(21);
            S5.Push(23);
            S5.Push(30);

            S6.Push(-8);
            S6.Push(-7);
            S6.Push(-4);

            S7.Push(7);
            S7.Push(8);
            S7.Push(11);
            S7.Push(12);
            S7.Push(15);

            S8.Push(12);
            S8.Push(13);
            S8.Push(14);

            // מימוש
            //Node<Stack<int>> L2 = new Node<Stack<int>>(S5);
            //Node<Stack<int>> Pos2 = L2;
            //Pos2.SetNext(new Node<Stack<int>>(S6));
            //Pos2 = Pos2.GetNext();
            //Pos2.SetNext(new Node<Stack<int>>(S7));
            //Pos2 = Pos2.GetNext();
            //Pos2.SetNext(new Node<Stack<int>>(S8));
            //Pos2 = Pos2.GetNext();
            //Stack<Stack<int>> FilledStack = FillRange(L2);
            //while (!FilledStack.IsEmpty())
            //{
            //    Console.WriteLine(FilledStack.Pop());
            //}

            // יצירת מסנית
            Stack<int> S9 = new Stack<int>();
            S9.Push(1);
            S9.Push(2);
            S9.Push(3);
            S9.Push(4);
            S9.Push(5);
            S9.Push(6);

            // מימוש
            //OppositePairs(S9);

            // יצירת מחסנית

        }
    }
}

