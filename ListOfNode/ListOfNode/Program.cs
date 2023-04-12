using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ListOfNode
{
    class Program
    {
        // N בנייה של שרשרת חוליות, הפעולה מקבלת את מספר החוליות 
        // הפעולה תחזיר שרשרת חוליות
        // למעשה, הפעוליה מחזירה את ההפניה\כתובת של החוליה הראשונה
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

        // שאלה מהספר
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
        //הפעולה מחזירה שרשרת חדשה ללא המספר שנקלת וללא כפילויות של שאר המספרים
        public static Node<int> RemoveNum(Node<int> L, int Num)
        {
            Node<int> NewL = null;
            Node<int> PosNewL = null;
            Node<int> PosL = L;
            while(PosL!=null)
            {
                if(PosL.GetValue()!=Num && !IsExist(NewL,PosL.GetValue()))
                {
                    if(NewL==null)
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
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Num of Nodes: ");
            int N = int.Parse(Console.ReadLine());
            Node<int> L = AddToLast(N);
            PrintList(L);
            Console.WriteLine();
            Node<int> NewL = RemoveNum(L, 3);
            PrintList(NewL);


        }
    }
}
