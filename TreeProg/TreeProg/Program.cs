using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProg
{
    class Program
    {
        // עץ בינארי הוא עץ שיש לו לפחות 2 בנים                                 

        public static void PrintPreOrder(BinNode<int> T)
        {
            if (T != null)
            {
                Console.Write(T.GetValue() + " ");
                PrintPreOrder(T.GetLeft());
                PrintPreOrder(T.GetRight());
            }
        }

        public static void PrintInOrder(BinNode<int> T)
        {
            if (T != null)
            {
                PrintInOrder(T.GetLeft());
                Console.Write(T.GetValue() + " ");
                PrintInOrder(T.GetRight());
            }
        }

        public static void PrintPostOrder(BinNode<int> T)
        {
            if (T != null)
            {
                PrintPostOrder(T.GetLeft());
                PrintPostOrder(T.GetRight());
                Console.Write(T.GetValue() + " ");
            }
        }

        // הדפסת עץ באופן ויזואלי
        // ========================================================
        public static void PrintBinTreeVisually<T>(BinNode<T> root)
        {
            int h = GetHeight(root);
            int spaces = (int)Math.Pow(2, h);
            String[,] arr = new String[2 * h, spaces];
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    arr[i, j] = " ";
            PrintBinTreeVisually(root, arr, 0, 0, spaces - 1);
            for (int i = 0; i < 2 * h; i++)
            {
                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static void PrintBinTreeVisually<T>(BinNode<T> node, String[,] arr, int i, int l, int r)
        {
            if (node == null)
                return;
            int m = (l + r) / 2;
            arr[i, m] = node.GetValue().ToString();
            PrintBinTreeVisually(node.GetLeft(), arr, i + 1, l, m - 1);
            PrintBinTreeVisually(node.GetRight(), arr, i + 1, m + 1, r);
        }

        private static int GetHeight<T>(BinNode<T> root)
        {
            if (root == null)
                return 0;
            int left = GetHeight(root.GetLeft());
            int right = GetHeight(root.GetRight());
            return Math.Max(left, right) + 1;
        }
        // ========================================================

        // טענת כניסה: כתוב פעולה המקבלת עץ של שלמים
        // טענת יציאה: הפעולה מדפיסה על פי סדר פרה אורדר את כל הצמתים עם הערך הזוגי
        public static void PrintEven(BinNode<int> T)
        {
            if (T != null)
            {
                if (T.GetValue() % 2 == 0)
                    Console.Write(T.GetValue() + " ");
                PrintEven(T.GetLeft());
                PrintEven(T.GetRight());
            }
        }

        // כתוב את סיבוכיות זמן הריצה של הפעולה ונמק:
        // תשובה:
        // סיבוכיות זמן הריצה היא 
        // O(n)
        // N = מספר הצמתים בעץ
        // הגענו לכל צומת פעם אחת והדפסנו את הערך של הצומת ולכן הסיבוכיות בצומת היא 
        // O(1)
        // O(1) * O(n) = O(n)


        // טענת כניסה: כתוב פעולה המקבלת עץ של שלמים
        // טענת יציאה: הפעולה תדפיס את כל העלים השמאליים

        // פעולת עזר: הפעולה מחזירה אמת אם הצומת האחרון עלה אחרת הפעולה תחזיר שקר
        public static bool IsLeaf(BinNode<int> T)
        {
            return (T.GetLeft() == null && T.GetRight() == null);
        }
        // הפעולה עצמה
        public static void PrintChildLeftIsLeaf(BinNode<int> T)
        {
            if (T != null)
            {
                if (T.hasLeft() && IsLeaf(T.GetLeft()))
                    Console.Write(T.GetLeft().GetValue() + " ");
                PrintChildLeftIsLeaf(T.GetLeft());
                PrintChildLeftIsLeaf(T.GetRight());
            }
        }

        // טענת כניסה: כתוב פעולה המקבלת עץ של שלמים ומספר שלם המציין את הרמה
        // טענת יציאה: הפעולה מדפיסה את כל הצמתים ברמה שקיבלה
        public static void PrintValueInLevel(BinNode<int> T, int Level)
        {
            if (T != null)
            {
                if (Level == 0)
                    Console.Write(T.GetValue() + " ");
                PrintValueInLevel(T.GetLeft(), Level - 1);
                PrintValueInLevel(T.GetRight(), Level - 1);
            }
        }

        // טענת כניסה: כתוב פעולה המקבלת עץ של שלמים
        // טענת יציאה: הפעולה מוסיפה לכל בן יחיד אח זהה לו
        public static void InsertBrother(BinNode<int> T)
        {
            if (T != null)
            {
                if (!T.hasLeft() && T.hasRight()) // אם קיים בן יחיד ימני
                    T.SetLeft(new BinNode<int>(T.GetRight().GetValue()));
                if (!T.hasRight() && T.hasLeft()) // אם קיים בן יחיד שמאלי
                    T.SetRight(new BinNode<int>(T.GetLeft().GetValue()));
                InsertBrother(T.GetLeft());
                InsertBrother(T.GetRight());
            }
        }

        // טענת כניסה: כתוב פעולה המקבלת עץ של שלמים
        // טענת יציאה: הפעולה מוחקת את כל העלים בעץ
        public static void DeleteLeaf(BinNode<int> T)
        {
            if (T != null)
            {
                if (T.hasLeft() && IsLeaf(T.GetLeft()))
                    T.SetLeft(null);
                if (T.hasRight() && IsLeaf(T.GetRight()))
                    T.SetRight(null);
                DeleteLeaf(T.GetLeft());
                DeleteLeaf(T.GetRight());
            }
        }

        // טענת כניסה: כתוב פעולה המקבלת עץ של שלמים
        // טענת יציאה: הפעולה מדפיסה את כל ההורים שערכם גדול מהבנים שלהם
        public static void PrintTheValueOfTheParentsWhoseValueIsBiggerThanTheirChildrensValue(BinNode<int> T)
        {
            if (T != null)
            {
                if (!T.hasRight() && T.hasLeft() && T.GetValue() > T.GetLeft().GetValue())
                {
                    Console.Write(T.GetValue() + " ");
                }
                else if (!T.hasLeft() && T.hasRight() && T.GetValue() > T.GetRight().GetValue())
                {
                    Console.Write(T.GetValue() + " ");
                }
                else if (T.hasLeft() && T.GetValue() > T.GetLeft().GetValue() && T.hasRight() && T.GetValue() > T.GetRight().GetValue())
                {
                    Console.Write(T.GetValue() + " ");
                }
                PrintTheValueOfTheParentsWhoseValueIsBiggerThanTheirChildrensValue(T.GetLeft());
                PrintTheValueOfTheParentsWhoseValueIsBiggerThanTheirChildrensValue(T.GetRight());
            }
        }

        // טענת כניסה: כתוב פעולה המקבלת עץ של שלמים
        // טענת יציאה: הפעולה מדפיסה את כל הנכדים בעץ
        public static void PrintGrandSons(BinNode<int> T)
        {
            if (T != null)
            {
                if (T.hasLeft() && !IsLeaf(T.GetLeft()) && T.GetLeft().hasLeft())
                    Console.Write(T.GetLeft().GetLeft().GetValue() + " ");
                if (T.hasLeft() && !IsLeaf(T.GetLeft()) && T.GetLeft().hasRight())
                    Console.Write(T.GetLeft().GetRight().GetValue() + " ");
                if (T.hasRight() && !IsLeaf(T.GetRight()) && T.GetRight().hasLeft())
                    Console.Write(T.GetRight().GetLeft().GetValue() + " ");
                if (T.hasRight() && !IsLeaf(T.GetRight()) && T.GetRight().hasRight())
                    Console.Write(T.GetRight().GetRight().GetValue() + " ");
                PrintGrandSons(T.GetLeft());
                PrintGrandSons(T.GetRight()); }
        }

        // טענת כניסה: כתוב פעולה המקבלת עץ של שלמים
        // טענת יציאה: הפעולה מחזירה את מספר הצמתים בעץ
        public static int CountBinNode(BinNode<int> T)
        {
            if (T == null)
                return 0;
            return CountBinNode(T.GetLeft()) + CountBinNode(T.GetRight()) + 1;
        }

        // טענת כניסה: הפעולה מקבלת עץ של שלמים
        // טענת יציאה: הפעולה מחזירה את כמות הערכים הזוגיים בעץ
        public static int CountEven(BinNode<int> T)
        {
            if (T == null)
                return 0;
            if (T.GetValue() % 2 == 0)
                return CountEven(T.GetLeft()) + CountEven(T.GetRight()) + 1;
            return CountEven(T.GetLeft()) + CountEven(T.GetRight());
        }

        // טענת כניסה: הפעולה מקבלת עץ של שלמים
        // טענת יציאה: הפעולה מחזירה את כמות הערכים האי זוגיים בעץ
        public static int CountOdd(BinNode<int> T)
        {
            if (T == null)
                return 0;
            if (T.GetValue() % 2 != 0)
                return CountOdd(T.GetLeft()) + CountOdd(T.GetRight()) + 1;
            return CountOdd(T.GetLeft()) + CountOdd(T.GetRight());
        }

        // טענת כניסה: הפעולה מקבלת עץ של שלמים
        // טענת יציאה: הפעולה מחזירה כמה בנים ימניים יש בעץ
        public static int RightSons(BinNode<int> T)
        {
            if (T == null)
                return 0;
            if (T.hasRight())
                return RightSons(T.GetLeft()) + RightSons(T.GetRight()) + 1;
            return RightSons(T.GetLeft()) + RightSons(T.GetRight());
        }

        // טענת כניסה: הפעולה מקבלת עץ של שלמים
        // טענת יציאה: הפעולה מחזירה כמה בנים שמאליים יש בעץ
        public static int LeftSons(BinNode<int> T)
        {
            if (T == null)
                return 0;
            if (T.hasLeft())
                return LeftSons(T.GetLeft()) + LeftSons(T.GetRight()) + 1;
            return LeftSons(T.GetLeft()) + LeftSons(T.GetRight());
        }

        // טענת כניסה: הפעולה מקבלת עץ של שלמים
        // טענת יציאה: הפעולה מחזירה כמה תאומים יש בעץ
        public static int CountTwins(BinNode<int> T)
        {
            if (T == null)
                return 0;
            if (T.hasLeft() && T.hasRight() && T.GetRight().GetValue() == T.GetLeft().GetValue())
                return CountTwins(T.GetLeft()) + CountTwins(T.GetRight()) + 1;
            return CountTwins(T.GetLeft()) + CountTwins(T.GetRight());
        }

        // טענת כניסה: הפעולה מקבלת עץ של שלמים
        // טענת יציאה: הפעולה מחזירה כמה עלים יש בעץ

        public static int CountLeaves(BinNode<int> T)
        {
            if (T == null)
                return 0;
            if (IsLeaf(T))
                return 1;
            return CountLeaves(T.GetLeft()) + CountLeaves(T.GetRight());
        }

        // טענת כניסה: הפעולה מקבלת עץ שלמים ומספר שלם
        // טענת יציאה: הפעולה מחזירה נכון או לא נכון אם המספר קיים
        public static bool IsExist(BinNode<int> T, int Num)
        {
            if (T == null)
                return false;
            if (T.GetValue() == Num)
                return true;
            return IsExist(T.GetLeft(), Num) || IsExist(T.GetRight(), Num);
        }

        // טענת כניסה: הפעולה מקבלת עץ של שלמים ומספר
        // טענת יציאה: הפעולה מחזירה כמה פעמים המספר נמצא בעץ
        public static int CountNumInTree(BinNode<int> T, int Num)
        {
            if (T == null)
                return 0;
            if (T.GetValue() == Num)
                return CountNumInTree(T.GetLeft(), Num) + CountNumInTree(T.GetRight(), Num) + 1;
            return CountNumInTree(T.GetLeft(), Num) + CountNumInTree(T.GetRight(), Num);
        }

        // טענת כניסה: הפעולה מקבלת עץ של שלמים
        // טענת יציאה: הפעולה מחזירה את הסכום של העץ הימני
        public static int SumTree(BinNode<int> T)
        {
            if (T == null)
                return 0;
            return T.GetValue() + SumTree(T.GetLeft()) + SumTree(T.GetRight());
        }

        // טענת כניסה: הפעולה מקבלת עץ של שלמים
        // טענת יציאה: הפעולה מחזירה האם העץ הוא עץ סכומים
        public static bool IsTreeSum(BinNode<int> T)
        {
            if (T == null || IsLeaf(T))
                return true;
            if (SumTree(T.GetRight()) + SumTree(T.GetLeft()) != T.GetValue())
                return false;
            return IsTreeSum(T.GetLeft()) && IsTreeSum(T.GetRight());
        }

        // טענת כניסה: הפעולה מקבלת עץ של שלמים
        // טענת יציאה: הפעולה מחזירה אמת או שקר אם לכל צומת יש 2 בנים - לא כולל עלים
        public static bool HasTwoSons(BinNode<int> T)
        {
            if (IsLeaf(T))
                return true;
            if (T.hasLeft() || T.hasRight())
                return false;
            return HasTwoSons(T.GetLeft()) && HasTwoSons(T.GetRight());
        }

        // טענת כניסה: הפעולה מקבלת עץ של שלמים
        // טענת יציאה: הפעולה מחזירה נכון אם העץ הוא עץ יורד
        public static bool IsDownTree(BinNode<int> T)
        {
            if (IsLeaf(T))
                return true;
            if (T.hasLeft() && T.hasRight())
                return false;
            if (!T.hasLeft() && T.hasRight() && T.GetValue() < T.GetRight().GetValue())
                return false;
            if (!T.hasRight() && T.hasLeft() && T.GetValue() < T.GetLeft().GetValue())
                return false;
            return IsDownTree(T.GetLeft()) && IsDownTree(T.GetRight());
        }

        // פעולה המדפיסה שרשרת חוליות
        public static void PrintList(Node<int> L)
        {
            Node<int> PostL = L;
            while (PostL != null)
            {
                Console.Write(PostL + " , ");
                PostL = PostL.GetNext();
            }
        }

        // שאלה שמשלבת שרשרת חוליות

        // פעולת עזר לסעיפים א וב
        // טענת כניסה: הפעולה מקבלת שרשרת חוליות של מספרים שלמים ומספר
        // טענת יציאה: הפעולה מחזירה אמת אם המספר נמצא בשרשרת אחרת תחזיר שקר
        public static bool IsExistInList(Node<int> L, int Num)
        {
            Node<int> PosL = L;
            while (PosL != null)
            {
                if (PosL.GetValue() == Num)
                    return true;
                PosL = PosL.GetNext();
            }
            return false;
        }

        // הפעולות עצמן

        // סעיף א
        // טענת כניסה: הפעולה מקבלת 2 שרשראות חוליות של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה שרשרת חדשה של מספרים שלמים המכילה את
        // המספרים המשותפים משתי השרשראות ללא כפילויות
        public static Node<int> CommonNumsList(Node<int> L1, Node<int> L2)
        {
            Node<int> PosL1 = L1;
            Node<int> PosL2 = L2;
            Node<int> NewL = null;

            while (PosL1 != null)
            {
                int Num = PosL1.GetValue();
                if (IsExistInList(PosL2, Num) && !IsExistInList(NewL, Num))
                    NewL = new Node<int>(Num, NewL);
                PosL1 = PosL1.GetNext();
            }

            return NewL;
        }

        // סעיף ב
        // טענת כניסה: הפעולה מקבלת 2 שרשראות חוליות של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה שרשרת חדשה של מספרים שלמים המכילה את
        // המספרים שלא משותפים לשני השרשראות ללא כפילויות
        public static Node<int> UncommonNumsList(Node<int> L1, Node<int> L2)
        {
            Node<int> PosL1 = L1;
            Node<int> PosL2 = L2;
            Node<int> NewL = null;

            while (PosL1 != null)
            {
                int Num = PosL1.GetValue();
                if (!IsExistInList(L2, Num) && !IsExistInList(NewL, Num))
                    NewL = new Node<int>(Num, NewL);
                PosL1 = PosL1.GetNext();
            }

            while (PosL2 != null)
            {
                int Num = PosL2.GetValue();
                if (!IsExistInList(L1, Num) && !IsExistInList(NewL, Num))
                    NewL = new Node<int>(Num, NewL);
                PosL2 = PosL2.GetNext();
            }

            return NewL;
        }

        // פעולת עזר
        // שמקבלת עץ בינארי של שלמים ומספר IsExistInTree שימוש בפעולת 
        // ומחזירה האם המספר נמצא בעץ

        // פעולה עוטפת
        // טענת כניסה: הפעולה מקבלת 2 עצים בינאריים של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה שרשרת חוליות של כל המספרים
        // המשותפים לשני העצים ללא כפילויות
        public static Node<int> ListOfCommonNumsInTrees(BinNode<int> t1, BinNode<int> t2)
        {
            Node<int> L = null;
            L = ListOfCommonNumsInTrees(t1, t2, L);
            return L;
        }

        // הפעולה עצמה
        // טענת כניסה: הפעולה מקבלת 2 עצים בינאריים ושרשרת חוליות של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה את השרשרת חוליות ככה שתכיל את כל המספרים
        // המשותפים לשני העצים ללא כפילויות
        public static Node<int> ListOfCommonNumsInTrees(BinNode<int> t1, BinNode<int> t2, Node<int> L)
        {
            if (t1 != null)
            {
                int Num = t1.GetValue();
                if (IsExist(t2, Num) && !IsExistInList(L, Num))
                    L = new Node<int>(Num, L);

                L = ListOfCommonNumsInTrees(t1.GetLeft(), t2, L);
                L = ListOfCommonNumsInTrees(t1.GetRight(), t2, L);
            }
            return L;
        }

        // שאלות מהספר - עמוד 177

        // שאלה 18
        // פעולת עזר
        // שבודקת האם מספר נמצא בעץ IsExistInTree שימוש בפעולה 

        // הפעולה עצמה
        // טענת כניסה: הפעולה מקבלת שני עצים בינאריים של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה האם על איברי העץ השני נמצאים בעץ הראשון
        public static bool IsT2InT1(BinNode<int> t1, BinNode<int> t2)
        {
            if (t2 == null)
                return true;

            int Num = t2.GetValue();

            if (!IsExist(t1, Num))
                return false;

            return IsT2InT1(t1, t2.GetLeft()) || IsT2InT1(t1, t2.GetRight());

        }

        // שאלה 20

        // פעולת עזר
        // טענת כניסה: הפעולה מקבלת עץ בינארי של מספרים שלמים ומספר
        // טענת יציאה: הפעולה מחזירה כמה פעמים הופיע המספר בעץ
        public static int CountAppearancesInTree(BinNode<int> t, int Num)
        {
            if (t == null)
                return 0;
            if (t.GetValue() == Num)
                return CountAppearancesInTree(t.GetLeft(), Num) + CountAppearancesInTree(t.GetRight(), Num) + 1;
            return CountAppearancesInTree(t.GetLeft(), Num) + CountAppearancesInTree(t.GetRight(), Num);
        }

        // הפעולה עצמה
        // N טענת כניסה: הפעולה מקבלת עץ בינארי של מספרים שלמים ומספר שלם 
        // טענת יציאה: הפעולה מחזירה האם העץ הוא עץ עוקבים
        // nעץ עוקבים הוא עץ שמכיל את כל המספרים מ1 עד ל
        // וכל אחד מהם מופיע פעם אחת בלבד
        public static bool FollowingToNTree(BinNode<int> t, int N)
        {
            if (t == null || N == 0)
                return true;

            if (CountAppearancesInTree(t, N) != 1)
                return false;

            return FollowingToNTree(t, N - 1);
        }

        // בגרות 2015 - בגרות ישנה שאלה 1
        // טענת כניסה: הפעולה מקבלת עץ ביטוי בוליאני
        // טענת יציאה: הפעולה מחזירה את הערך הבוליאני של הביטוי שהעץ מייצג

        // שימוש במפעולת עזר - IsLeafStr
        // פעולת עזר: הפעולה מחזירה אמת אם הצומת האחרון עלה אחרת הפעולה תחזיר שקר
        public static bool IsLeafStr(BinNode<string> T)
        {
            return (T.GetLeft() == null && T.GetRight() == null);
        }
        public static bool TreeExp(BinNode<string> T)
        {
            if (IsLeafStr(T))
            {
                if (T.GetValue() == "T")
                    return true;
                return false;
            }

            if (T.GetValue() == "AND")
            {
                return TreeExp(T.GetLeft()) && TreeExp(T.GetRight());
            }

            return TreeExp(T.GetLeft()) || TreeExp(T.GetRight());
        }

        // טענת כניסה: כתוב פעולה המקבלת 2 עצים בינארים של מספרים שלמים
        // טענת יציאה: הפעולה תחזיר שרשרת חוליות מטיפוס אייטם שמכילה את כל המספרים המשותפים שהיו בשני העצים
        // במחלקת אייטם יש את המספר עצמו ואת כמות הפעמים שהופיע

        // שימוש בפעולת IsExist
        // הפעולה מקבלת עץ שלמים ומספר שלם ומחזירה נכון או לא נכון אם המספר קיים

        // שימוש בפעולה IsExistItemNode
        // טענת כניסה: הפעולה מקבלת שרשרת של אייטמים ומספר שלם
        // טענת יציאה: הפעולה מחזירה אמת אם המספר נמצא בשרשרת, אחרת מחזירה שקר
        public static bool IsExistItemNode(Node<Item> L, int Num)
        {
            Node<Item> PosL = L;
            while (PosL != null)
            {
                if (PosL.GetValue().GetNum() == Num)
                    return true;
                PosL = PosL.GetNext();
            }
            return false;
        }

        //שימוש בפעולת CountNumInTree
        //הפעולה מקבלת עץ של שלמים ומספר ומחזירה כמה פעמים המספר נמצא בעץ

        public static Node<Item> CountCommonNums(BinNode<int> T1, BinNode<int> T2)
        {
            Node<Item> L = null;
            return CountCommonNums(T1, T2, L);
        }
        public static Node<Item> CountCommonNums(BinNode<int> T1, BinNode<int> T2, Node<Item> L)
        {
            if (T1 != null)
            {
                if (!IsExistItemNode(L, T1.GetValue()))
                {
                    int Count = CountNumInTree(T2, T1.GetValue());
                    if (Count > 0)
                    {
                        Item I = new Item(T1.GetValue(), Count);
                        L = new Node<Item>(I, L);
                    }
                }
                L = CountCommonNums(T1.GetLeft(), T2, L);
                L = CountCommonNums(T1.GetRight(), T2, L);
            }
            return L;

        }

        // שימוש בפעולת עזר סופית PrintList
        public static void PrintList(Node<Item> L)
        {
            Node<Item> PosL = L;
            while (PosL != null)
            {
                Console.Write(PosL.GetValue().ToString() + ", ");
                PosL = PosL.GetNext();
            }
            Console.WriteLine();
        }

        //--------------------------------------------------------
        // פעולת עזר
        // טענת כניסה: הפעולה מקבלת שלושה מספרים שלמים
        // טענת יציאה: הפעולה מחזירה את המספר הגדול מבין השלושה
        public static int MaxInThreeNums(int Num1, int Num2, int Num3)
        {
            return Math.Max(Math.Max(Num1, Num2), Num3);
        }

        // הפעולה הראשית
        // טענת כניסה: הפעולה מקבלת עץ בינארי של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה את המספר הגדול ביותר בעץ
        public static int MaxInTree(BinNode<int> T)
        {
            if (IsLeaf(T))
                return T.GetValue();
            if (T.GetLeft() == null)
                return Math.Max(T.GetValue(), MaxInTree(T.GetRight()));
            if (T.GetRight() == null)
                return Math.Max(T.GetValue(), MaxInTree(T.GetLeft()));
            return MaxInThreeNums(T.GetValue(), MaxInTree(T.GetRight()), MaxInTree(T.GetLeft()));
        }

        // טענת כניסה: הפעולה מקבלת עץ של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה את גובה העץ
        public static int TreeHeight(BinNode<int> T)
        {
            if (T == null)
                return -1;
            return Math.Max(TreeHeight(T.GetLeft()), TreeHeight(T.GetRight())) + 1;
        }

        // פעולות המשלבות סריקות רוחב
        // ------------------------------------------------------
        // טענת כניסה: הפעולה מקבלת עץ בינארי של מספרים שלמים
        // טענת יציאה: הפעולה מדפיסה את ערכי הצמתים לפי סריקת רוחב
        public static void PrintLevelOrder(BinNode<int> t)
        {
            Queue<BinNode<int>> Q = new Queue<BinNode<int>>();
            Q.Insert(t);
            BinNode<int> tempT = t;
            while (!Q.IsEmpty())
            {
                tempT = Q.Remove();
                Console.WriteLine(tempT.GetValue());
                if (tempT.hasLeft())
                    Q.Insert(tempT.GetLeft());
                if (tempT.hasRight())
                    Q.Insert(tempT.GetRight());
            }

        }
        // ------------------------------------------------------

        // ------------------------------------------------------
        // טענת כניסה: הפעולה מקבלת עץ בינארי של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה אמת אם העץ ממויין לפי הרמות שלו
        // אחרת הפעולה תחזיר שקר
        public static bool IsSortedByLevel(BinNode<int> t)
        {
            Queue<BinNode<int>> Q = new Queue<BinNode<int>>();
            Q.Insert(t);
            while (!Q.IsEmpty())
            {
                t = Q.Remove();
                if (!Q.IsEmpty())
                {
                    if (Q.Head().GetValue() > t.GetValue())
                        return false;
                }
                if (t.hasRight())
                    Q.Insert(t.GetRight());
                if (t.hasLeft())
                    Q.Insert(t.GetLeft());

            }
            return true;
        }

        // ------------------------------------------------------
        // (שאלות לבוחן בשיעור של טליה (ללא צורך בתור
        // 10/03/2023

        // שאלה 1
        // ------------------------------------------------------

        // פעולה עוטפת
        // טענת כניסה: הפעולה מקבלת עץ בינארי של מספרים שלמים
        // טענת יציאה: הפעולה מדפיסה את כל הרמות הזוגיות בעץ
        public static void PrintEvenLevels(BinNode<int> t)
        {
            PrintEvenLevels(t, 0);
        }

        // הפעולה הראשית
        // טענת כניסה: הפעולה מקבלת עץ בינארי של מספרים שלמים ומספר שלם
        // טענת יציאה: הפעולה מדפיסה את כל הרמות הזוגיות בעץ
        public static void PrintEvenLevels(BinNode<int> t, int Level)
        {
            if (t != null)
            {
                if (Level % 2 == 0)
                    Console.Write(t.GetValue() + " ");

                PrintEvenLevels(t.GetLeft(), Level + 1);
                PrintEvenLevels(t.GetRight(), Level + 1);
            }
        }

        // שאלה 2
        // פעולת עזר
        // שמקבלת עץ בינארי של מספרים שלמים TreeHeight שימוש בפעולה  
        // ומחזירה את גובה העץ

        // פעולת עזר
        // טענת כניסה: הפעולה מקבלת עץ בינארי של מספרים שלמים
        // ומספר שלם המציין רמה בעץ
        // טענת יציאה: הפעולה מחזירה את סכום הצמתים שנמצאים ברמה
        // שקיבלה בעץ
        public static int SumInLevel(BinNode<int> t, int Level)
        {
            if (t != null)
            {
                if (Level == 0)
                    return t.GetValue();

                return SumInLevel(t.GetLeft(), Level - 1) + SumInLevel(t.GetRight(), Level - 1);
            }
            return 0;
        }


        // הפעולה הראשית
        // טענת כניסה: הפעולה מקבלת עץ בינארי של מספרים שלמים 
        // טענת יציאה: הפעולה מדפיסה את הסכום של כל הערכים של כל רמה בנפרד
        public static void PrintLevelsSums(BinNode<int> t)
        {
            for (int i = 0; i <= TreeHeight(t); i++)
            {
                Console.WriteLine(i + ": " + SumInLevel(t, i));
            }
        }

        // שאלה 3
        // פעולת עזר
        // שמקבלת עץ בינארי של מספרים שלמים TreeHeight שימוש בפעולה  
        // ומחזירה את גובה העץ

        // פעולת עזר
        // טענת כניסה: הפעולה מקבלת עץ בינארי של מספרים שלמים
        // ומספר שלם המציין רמה בעץ
        // טענת יציאה: הפעולה מחזירה את ערכו של הצומת הראשון ברמה
        // שקיבלה בעץ
        public static int FirstInLevel(BinNode<int> t, int Level)
        {
            if (t != null)
            {
                if (Level == 0)
                    return t.GetValue();

                if (t.hasLeft() && (Level - 1) <= TreeHeight(t.GetLeft()))
                    return FirstInLevel(t.GetLeft(), Level - 1);

                return FirstInLevel(t.GetRight(), Level - 1);
            }
            return -1;
        }

        // הפעולה הראשית
        // טענת כניסה: הפעולה מקבלת עץ בינארי של מספרים שלמים 
        // טענת יציאה: הפעולה מדפיסה את ערכו של הצומת הראשון בכל רמה בעץ
        public static void PrintFirstInLevels(BinNode<int> t)
        {
            for (int i = 0; i <= TreeHeight(t); i++)
            {
                Console.WriteLine(i + ": " + FirstInLevel(t, i));
            }
        }

        // טענת כניסה: הפעולה מקבלת תור של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה תור מטיפוס אייטם שיכיל רק את המספרים שהופיעו ברצף בתור המקורי שקיבלנו לפחות שלוש פעמים
        public static Queue<Item> ThreeSequence(Queue<int> Q)
        {
            Queue<int> CopyQ = Q.CopyQueue();
            Queue<Item> ReturnQ = new Queue<Item>();
            if (CopyQ.IsEmpty())
                return ReturnQ;
            int Count = 1;
            int First = CopyQ.Remove();
            while (!CopyQ.IsEmpty())
            {
                if (CopyQ.Head() != First)
                {
                    if (Count >= 3)
                    {
                        ReturnQ.Insert(new Item(First, Count));
                    }
                    First = CopyQ.Head();
                    Count = 1;
                }
                else
                    Count++;
                CopyQ.Remove();
            }
            if (Count >= 3)
            {
                ReturnQ.Insert(new Item(First, Count));
            }
            return ReturnQ;
        }

        // הדפסת תור באופן גנרי
        public static void PrintQueueGeneric<T>(Queue<T> Q)
        {
            Queue<T> CopyQ = Q.CopyQueue();
            Console.Write("[");
            while (!CopyQ.IsEmpty())
            {
                Console.WriteLine(CopyQ.Head() + ", ");
                CopyQ.Remove();
                Console.Write("]");
            }
        }
                    
        // שאלת בגרות בעצים- שאלה 6 - בגרות 2020

        // נשתמש בפעולה עוטפת לצורך פתירת התרגיל
        // טענת יציאה: הפעולה מקבלת עץ בינארי של מספרים שלמים
        // טענת יציאה: הפעולה מדפיסה את כל המספרים שהמסלולים בעץ מייצגים
        public static void PrintAll(BinNode<int> T)
        {
            PrintAll(T, 0);
        }
        // טענת יציאה: הפעולה מקבלת עץ בינארי של מספרים שלמים ומספר שלם
        // טענת יציאה: הפעולה מדפיסה את כל המספרים שהמסלולים בעץ מייצגים
        public static void PrintAll(BinNode<int> T, int Num)
        {
            if (T != null)
            {
                if (IsLeaf(T))
                {
                    Console.WriteLine(Num * 10 + T.GetValue());
                }
                else
                {
                    PrintAll(T.GetLeft(), Num * 10 + T.GetValue());
                    PrintAll(T.GetRight(), Num * 10 + T.GetValue());
                }
            }
        }

        // טענת כניסה: הפעולה מקבלת עץ בינארי של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה אמת אם כל הצמתים בעץ זוגיים אחרת מחזירה שקר
        public static bool IsEven(BinNode<int> T)
        {
            if (T != null)
            {
                if (T.GetValue() % 2 == 0)
                {
                    return IsEven(T.GetLeft()) && IsEven(T.GetRight());
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        // שאלת בגרות בעצים - בגרות 2016 ישנה מועד א - שאלה 2

        // טענת כניסה: הפעולה מקבלת עץ בינארי של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה אמת אם יש בעץ מסלול המתחיל בשורש העץ ומסתיים באחד העלים שלו, וערכי הצמתים ממויינים בסדר עולה מהשורש לעלה
        // אם אין מסלול כזה הפעולה מחזירה שקר
        public static bool RisingPath(BinNode<int> T)
        {
            if (T != null)
            {
                if (T.hasLeft() && T.hasRight())
                {
                    //bool left = RisingPath(T.GetLeft());
                    //bool right = RisingPath(T.GetRight());

                    if (T.GetValue() < T.GetLeft().GetValue() && T.GetValue() < T.GetRight().GetValue())
                    {
                        return RisingPath(T.GetLeft()) || RisingPath(T.GetRight());
                    }

                    if (T.GetValue() < T.GetLeft().GetValue())
                    {
                        return RisingPath(T.GetLeft());
                    }

                    if (T.GetValue() < T.GetRight().GetValue())
                    {
                        return RisingPath(T.GetRight());
                    }

                }

                if (T.hasLeft() && !T.hasRight())
                {
                    if (T.GetValue() < T.GetLeft().GetValue())
                    {
                        return RisingPath(T.GetLeft());
                    }
                }

                if(!T.hasLeft() && T.hasRight())
                {
                    if (T.GetValue() < T.GetRight().GetValue())
                    {
                        return RisingPath(T.GetRight());
                    }
                }

                if (IsLeaf(T))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        // דרך נוספת לשאלה שלעיל - שאלת בגרות בעצים - בגרות 2016 ישנה מועד א - שאלה 2

        // נשתמש בפעולה עוטפת לצורך פתירת התרגיל
        // טענת כניסה: הפעולה מקבלת עץ בינארי של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה אמת אם יש בעץ מסלול המתחיל בשורש העץ ומסתיים באחד העלים שלו
        // וערכי הצמתים ממויינים בסדר עולה מהשורש לעלה
        // אם אין מסלול כזה הפעולה מחזירה שקר
        public static bool RisingPath2(BinNode<int> T)
        {
            return RisingPath2(T.GetLeft(), T.GetValue()) || RisingPath2(T.GetRight(), T.GetValue());
        }
        public static bool RisingPath2(BinNode<int> T, int Prev)
        {
            if (T != null)
            {
                if (T.GetValue() <= Prev)
                {
                    return false;
                }

                return RisingPath2(T.GetLeft(), T.GetValue()) || RisingPath2(T.GetRight(), T.GetValue());
            }
            else
            {
                return true;
            }
        }
        
        // טענת כניסה: הפעולה מקבלת עץ בינארי של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה את סכום ערכי הצמתים שערכם גבוה יותר מהערך של אחיהם
        // אם יש בן בודד הפעולה תחשיב אותו כאח הגבוה ביותר
        public static int SumBiggerBrothers(BinNode<int> T)
        {
            if (T != null)
            {
                int MaxBro = 0;
                if (T.hasLeft() == T.hasRight())
                    MaxBro = Math.Max(T.GetLeft().GetValue(), T.GetRight().GetValue());
                if (T.hasLeft())
                    MaxBro = T.GetLeft().GetValue();
                if (T.hasRight())
                    MaxBro = T.GetRight().GetValue();
                return SumBiggerBrothers(T.GetLeft()) + SumBiggerBrothers(T.GetRight());
            }
            return 0;
        }

        // שאלת בגרות בעצים 2022 שאלה 7

        // נתונה פעולת עזר נתונה EraseFirst
        // טענת כניסה: הפעולה מקבלת מחרוזת
        // טענת יציאה: הפעולה מחזירה תת־מחרוזת של המחרוזת שקיבלנו ללא התו הראשון
        public static string EraseFirst(string Str)
        {
            Str = Str.Substring(1);
            return Str;
        }

        // הפעולה עצמה
        // טענת כניסה: הפעולה מקבלת עץ בינארי של צארים ומחרוזת
        // טענת יציאה: הפעולה מחזירה אמת אם קיים מסלול המתחיל בשורש העץ שבו רצף התווים זהה למחרוזת הזהה למחרוזת שקיבלנו
        // אחרת הפעולה תחזיר שקר
        public static bool WordFromRoot(BinNode<char> T, string Str)
        {
            if (Str == "")
                return true;
            if (T == null)
                return false;
            if (T.GetValue() != Str[0])
                return false;
            Str = EraseFirst(Str);
            return WordFromRoot(T.GetLeft(), Str) || WordFromRoot(T.GetRight(), Str);
        }

        // שאלת בגרות 2022 שאלה 4 - מחליפים את השימוש של שרשרת חוליות בתור

        // טענת כניסה: הפעולה מקבלת שני תורים, אחד מטיפוס ריינג והשני מטיפוס שלם
        // טענת יציאה: הפעולה מחזירה אמת אם הערכים בתור הראשון- התור של השלמים, מוכלים בתור השני- בתור של הריינגים
        // שני התורים ממויינים בסדר עולה
        public static bool IsIncluded(Queue<int> Q1, Queue<Range> Q2)
        {
            Queue<int> CopyQ1 = Q1.CopyQueue();
            Queue<Range> CopyQ2 = Q2.CopyQueue();
            while (!CopyQ1.IsEmpty() && !CopyQ2.IsEmpty())
            {
                if (CopyQ1.Head() < CopyQ2.Head().GetLow())
                    return false;
                if (CopyQ1.Head() > CopyQ2.Head().GetHigh())
                    CopyQ2.Remove();
                else
                    CopyQ1.Remove();
            }
            if (CopyQ1.IsEmpty())
                return true;
            return false;
        }

        // שאלת בגרות 2021 שאלה 7 - תור

        // פעולת עזר נתונה
        // טענת כניסה: הפעולה מקבלת תור של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה את מספר האיברים בתור מבלי לשנות את התור
        public static int QueueSize(Queue<int> Q)
        {
            Queue<int> CopyQ = Q.CopyQueue();
            int Count = 0;
            while (!CopyQ.IsEmpty())
            {
                CopyQ.Remove();
                Count++;
            }
            return Count;
        }

        // סעיף א
        // טענת כניסה: הפעולה מקבלת שני תורים מטיפוס שלם
        // טענת יציאה: הפעולה מחזירה אמת אם התורים זהים אחרת מחזירה שקר
        public static bool IsIdentical(Queue<int> Q1, Queue<int> Q2)
        {
            Queue<int> CopyQ1 = Q1.CopyQueue();
            Queue<int> CopyQ2 = Q2.CopyQueue();
            if (QueueSize(CopyQ1) != QueueSize(CopyQ2))
                return false;
            while (!CopyQ1.IsEmpty())
            {
                if (CopyQ1.Remove() != CopyQ2.Remove())
                    return false;
            }
            return true;
        }

        // סעיף ב
        // טענת כניסה: הפעולה מקבלת שני תורים מטיפוס שלם
        // טענת יציאה: הפעולה מחזירה אמת אם שני התורים שקיבלנו זהים
        // בין שהם זהים כמו שהם ובין שהם יהיו זהים לאחר שנבצע באחד מהתורים "העברה מההתחלה לסוף", פעם אחת או יותר
        // אחרת הפעולה מחזירה שקר
        public static bool IsSimilar(Queue<int> Q1, Queue<int> Q2)
        {
            Queue<int> CopyQ1 = Q1.CopyQueue();
            Queue<int> CopyQ2 = Q2.CopyQueue();
            int Q1Size = QueueSize(CopyQ1);
            if (Q1Size != QueueSize(CopyQ2))
                return false;
            for (int i = 0; i < Q1Size; i++)
            {
                if (IsIdentical(CopyQ1, CopyQ2))
                    return true;
                CopyQ1.Insert(CopyQ1.Remove());
            }
            return false;  
        }

        // בגרות 2020 מועד ב שאלה 6 - עצים

        // נשתמש בפעולה עוטפת לצורך פתירת התרגיל
        // טענת כניסה: הפעולה מקבלת עץ בינארי של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה אמת אם העץ הוא "עץ שאריות שוויוני" אחרת מחזירה שקר
        // עץ שאריות שוויוני - כמות האיברים שמספריהם מתחלקים ב־ 3 עם שארית 1
        // שווה לכמות האיברים שמספריהם מתחלקים ב־ 3 עם שארית 2
        // ושווה לכמות האיברים שמספריהם מתחלקים ב- 3 ללא שארית
        public static bool TreeEqual(BinNode<int> T)
        {
            return TreeEqual(T, 0, 0, 0);
        }
        // טענת כניסה: הפעולה מקבלת עץ בינארי של מספרים שלמים ושלושה סכומים - מספרים שלמים
        // טענת יציאה: הפעולה מחזירה אמת אם העץ הוא "עץ שאריות שוויוני" אחרת מחזירה שקר
        public static bool TreeEqual(BinNode<int> T, int Sum0, int Sum1, int Sum2)
        {
            if (T == null)
            {
                if (T.GetValue() % 3 == 0)
                    Sum0++;
                if (T.GetValue() % 3 == 1)
                    Sum1++;
                if (T.GetValue() % 3 == 2)
                    Sum2++;
                TreeEqual(T.GetLeft(), Sum0, Sum1, Sum2);
                TreeEqual(T.GetRight(), Sum0, Sum1, Sum2);
            }
            if (Sum0 == Sum1 && Sum0 == Sum2)
                return true;
            return false;
        }

        // שאלת בגרות 2021 מועד ב שאלה 6 - תור

        // לצורך פתירת התרגיל נחוצה פעולת עזר
        // טענת כניסה: הפעולה מקבלת תור מטיפוס "קוביד-טסט" וקוד של עיר- מספר מטיפוס שלם
        // טענת יציאה: הפעולה מחזירה כמה חולים יש בעיר שקיבלנו את הקוד שלה
        public static int CountSickInCity(Queue<CovidTest> Q, int CityCode)
        {
            Queue<CovidTest> CopyQ = Q.CopyQueue();
            int Total = 0;
            while (!CopyQ.IsEmpty())
            {
                if (CopyQ.Head().GetCityCode() == CityCode && CopyQ.Head().GetSick() == true)
                    Total++;
                CopyQ.Remove();
            }
            return Total;
        }

        // הפעולה עצמה
        // טענת כניסה: הפעולה מקבלת תור מטיפוס קוביד-טסט
        // טענת יציאה: הפעולה מחזירה את הקוד של העיר שבה כמות החולים היא הגדולה ביותר
        public static int MostSick(Queue<CovidTest> Q)
        {
            Queue<CovidTest> CopyQ = Q.CopyQueue();
            int CurrentlyCityMostSick = 0;
            int MaxSickCityCode = 0;
            while (!CopyQ.IsEmpty())
            {
                int CurrentlyCitySick = CountSickInCity(CopyQ, CopyQ.Head().GetCityCode());
                if (CurrentlyCitySick > CurrentlyCityMostSick)
                {
                    CurrentlyCityMostSick = CurrentlyCitySick;
                    MaxSickCityCode = CopyQ.Head().GetCityCode();
                }
                CopyQ.Remove();
            }
            return MaxSickCityCode;
        }

        // בגרות 2007 שאלה 3 - עצים בינאריים

        // טענת כניסה: הפעולה מקבלת עץ של שלמים
        //  טענת יציאה: הפעולה מחזירה אמת אם קיים מסלול אחיד
        // מסלול אחיד - מסלול המתחיל בשורש העץ ומסתיים באחד העלים שלו, ועל ערכי הצמתים בו זהים
        // אם לא קיים מסלול כזה, הפעולה מחזירה שקר
        public static bool OnePath(BinNode<int> T)
        {
            return OnePath(T, T.GetValue());
        }
        public static bool OnePath(BinNode<int> T, int Daddy)
        {
            if (T != null)
            {
                if (T.GetValue() != Daddy)
                    return false;
                return OnePath(T.GetLeft(), Daddy) || OnePath(T.GetRight(), Daddy);
            }
            return true;
        }

        // ------------------------------------------------------

        // שאלה שכדאי לדעת למבחן
        // טענת כניסה: הפעולה מקבלת עץ בינארי של מספרים שלמים ומספר
        // שלם המציין רמה בעץ
        // טענת יציאה: הפעולה מחזירה כמה צמתים יש ברמה שקיבלה בעץ
        

        // שאלה למבחן 31.03.23
        // טענת כניסה: הפעולה מקבלת עץ בינארי מטיפוס שלם ושני מספרים מטיפוס שלם המייצגים שני צמתים בעץ
        // טענת יציאה: הפעולה מחזירה אמת אם שני המספרים שקיבלנו הם בני דודים - סבא משותף
        // אחרת הפעולה מחזירה שקר
        public static bool IsCousins(BinNode<int> T, int Node1, int Node2)
        {
            if (T != null && T.hasLeft() && T.hasRight())
            {
                if (T.GetLeft().hasLeft() && T.GetLeft().GetLeft().GetValue() == Node1
                    || T.GetLeft().hasRight() && T.GetLeft().GetRight().GetValue() == Node1)
                {
                    if (T.GetRight().hasLeft() && T.GetRight().GetLeft().GetValue() == Node2
                        || T.GetRight().hasRight() && T.GetRight().GetRight().GetValue() == Node2)
                        return true;
                }

                if (T.GetLeft().hasLeft() && T.GetLeft().GetLeft().GetValue() == Node2
                    || T.GetLeft().hasRight() && T.GetLeft().GetRight().GetValue() == Node2)
                {
                    if (T.GetRight().hasLeft() && T.GetRight().GetLeft().GetValue() == Node1
                        || T.GetRight().hasRight() && T.GetRight().GetRight().GetValue() == Node1)
                        return true;
                }
                return IsCousins(T.GetLeft(), Node1, Node2) || IsCousins(T.GetRight(), Node1, Node2);
            }
            return false;
        }



        static void Main(string[] args)
        {
            // יצירת עץ ראשון
            BinNode<int> T2 = new BinNode<int>(15);
            T2.SetLeft(new BinNode<int>(-3));
            T2.SetRight(new BinNode<int>(6));

            BinNode<int> T3 = new BinNode<int>(8);
            T3.SetRight(new BinNode<int>(9));
            T3.GetRight().SetLeft(new BinNode<int>(28));
            T3.GetRight().SetRight(new BinNode<int>(14));

            BinNode<int> T1 = new BinNode<int>(T2, 42, T3);

            // הדפסת העץ באופן וויזואלי 
            PrintBinTreeVisually(T1);

            // Pre Order, In Order, Post Order
            Console.WriteLine("\n" + "======================================");
            Console.WriteLine("Pre Order: ");
            PrintPreOrder(T1);
            Console.WriteLine("\n" + "In Order: ");
            PrintInOrder(T1);
            Console.WriteLine("\n" + "Post Order ");
            PrintPostOrder(T1);

            // יצירת עץ שני
            Console.WriteLine("\n" + "======================================");
            BinNode<int> T4 = new BinNode<int>(10);
            T4.SetLeft(new BinNode<int>(6));
            T4.SetRight(new BinNode<int>(4));

            BinNode<int> T5 = new BinNode<int>(20);
            T5.SetRight(new BinNode<int>(10));
            T5.GetRight().SetRight(new BinNode<int>(2));
            T5.GetRight().SetLeft(new BinNode<int>(8));

            BinNode<int> T6 = new BinNode<int>(T4, 60, T5);

            // הדפסת העץ באופן וויזואלי 
            PrintBinTreeVisually(T6);

            // ========================================================================================================

            //Console.WriteLine("\n");
            //PrintEven(T1);

            //Console.WriteLine("\n");
            //PrintChildLeftIsLeaf(T1);

            //Console.WriteLine("\n");
            //PrintValueInLevel(T1, 3);

            //Console.WriteLine("\n");
            //InsertBrother(T1);

            //Console.WriteLine("\n");
            //DeleteLeaf(T1);
            //PrintPreOrder(T1);

            //Console.WriteLine("\n");
            //PrintTheValueOfTheParentsWhoseValueIsBiggerThanTheirChildrensValue(T1);

            //Console.WriteLine("\n");
            //PrintGrandSons(T1);

            //Console.WriteLine("\n");
            //Console.WriteLine(CountBinNode(T1));

            //Console.WriteLine("\n");
            //Console.WriteLine(CountEven(T1)); 

            //Console.WriteLine("\n");
            //Console.WriteLine(CountOdd(T1)); 

            //Console.WriteLine("\n");
            //Console.WriteLine(RightSons(T1)); 

            //Console.WriteLine("\n");
            //Console.WriteLine(LeftSons(T1)); 

            //Console.WriteLine("\n");
            //Console.WriteLine(CountTwins(T1));

            //Console.WriteLine("\n");
            //Console.WriteLine(CountLeaves(T1));

            //Console.WriteLine("\n");
            //Console.WriteLine(IsExist(T1, -3));

            //Console.WriteLine("\n");
            //Console.WriteLine(CountNumInTree(T1, 6)); 

            //Console.WriteLine("\n");
            //Console.WriteLine(IsTreeSum(T6));

            // ========================================================================================================

            // שימוש בפעולות המשלבות שרשראות של חוליות

            // יצירת שרשרת חוליות ראשונה בעזרת הוספה לסוף
            Node<int> L1 = new Node<int>(4);
            Node<int> Pos1 = L1;
            Pos1.SetNext(new Node<int>(3));
            Pos1 = Pos1.GetNext();
            Pos1.SetNext(new Node<int>(11));
            Pos1 = Pos1.GetNext();
            Pos1.SetNext(new Node<int>(2));
            Pos1 = Pos1.GetNext();
            Pos1.SetNext(new Node<int>(6));
            Pos1 = Pos1.GetNext();
            Pos1.SetNext(new Node<int>(100));

            // הדפסת השרשרת
            Console.WriteLine("L1: ");
            PrintList(L1);
            Console.WriteLine("\n");

            // יצירת שרשרת חוליות שנייה בעזרת הוספה לסוף

            Node<int> L2 = new Node<int>(10);
            Node<int> Pos2 = L2;
            Pos2.SetNext(new Node<int>(11));
            Pos2 = Pos2.GetNext();
            Pos2.SetNext(new Node<int>(19));
            Pos2 = Pos2.GetNext();
            Pos2.SetNext(new Node<int>(1));
            Pos2 = Pos2.GetNext();
            Pos2.SetNext(new Node<int>(7));
            Pos2 = Pos2.GetNext();
            Pos2.SetNext(new Node<int>(100));

            // הדפסת השרשרת
            Console.WriteLine("L2: ");
            PrintList(L2);
            Console.WriteLine("\n");

            // שרשרת חוליות של המספרים המשותפים לשני שרשראות
            Console.WriteLine("Common nums in lists: ");
            PrintList(CommonNumsList(L1, L2));
            Console.WriteLine("\n");

            // שרשרת חוליות של המספרים שלא המשותפים לשני שרשראות
            Console.WriteLine("Uncommon nums in lists: ");
            PrintList(UncommonNumsList(L1, L2));
            Console.WriteLine("\n");


            // שימוש נוסף בפעולות המשלבות שרשראות של חוליות עם עצים בינאריים
            // שימוש בפעולה המקבלת שני עצים בינאריים ומחזירה שרשרת חוליות
            // של המספרים המשותפים לעצים ללא כפילויות
            PrintList(ListOfCommonNumsInTrees(T1, T6));

            // שאלות מהספר - עמוד 177

            // שאלה 18
            // האם ערכי צמתים בעץ אחד נמצאים בתוך עץ אחר
            Console.WriteLine();
            Console.WriteLine("Is T5 Values In T6: " + IsT2InT1(T6, T5));


            // יצירת עץ נוסף
            BinNode<int> T7 = new BinNode<int>(1);
            T7.SetLeft(new BinNode<int>(2));
            T7.SetRight(new BinNode<int>(3));

            BinNode<int> T8 = new BinNode<int>(4);
            T8.SetRight(new BinNode<int>(5));
            T8.GetRight().SetRight(new BinNode<int>(6));
            T8.GetRight().SetLeft(new BinNode<int>(7));

            BinNode<int> T9 = new BinNode<int>(T7, 8, T8);

            // הדפסת העץ באופן וויזואלי 
            PrintBinTreeVisually(T9);

            // שאלה 20
            // האם העץ מכיל את המספרים מ1 עד למספר הנוסף כפרמטר רק פעם אחת
            Console.WriteLine();
            Console.WriteLine("Is T9 a following to N tree (N = 8): " + FollowingToNTree(T9, 8));

            // מימוש הפעולה CountCommonNums
            Console.WriteLine();
            //PrintList(CountCommonNums(T6, T9));

            // סריקות רוחב
            // עץ בינארי חדש
            BinNode<int> T16 = new BinNode<int>(2);
            BinNode<int> T17 = new BinNode<int>(3);
            BinNode<int> T18 = new BinNode<int>(T16, 1, T17);

            // הדפסת העץ באופן וויזואלי 
            Console.WriteLine();
            Console.WriteLine("T18: \n");
            PrintBinTreeVisually(T18);

            // עץ בינארי חדש
            BinNode<int> T13 = new BinNode<int>(2);
            T13.SetLeft(new BinNode<int>(83));
            T13.GetLeft().SetLeft(new BinNode<int>(92));

            BinNode<int> T14 = new BinNode<int>(5);
            T14.SetRight(new BinNode<int>(123));

            BinNode<int> T15 = new BinNode<int>(T13, 16, T14);

            // הדפסת העץ באופן וויזואלי 
            Console.WriteLine("T15: \n");
            PrintBinTreeVisually(T15);

            // פעולה המקבלת עץ בינארי של מספרים שלמים
            // ומדפיסה את ערכי הצמתים בעץ לפי סריקת רוחב
            Console.WriteLine();
            Console.WriteLine("T18 values by width scan: ");
            PrintLevelOrder(T18);


            // פעולה המקבלת עץ בינארי של מספרים שלמים
            // ומחזירה האם העץ ממויין לפי רמות
            Console.WriteLine();
            Console.WriteLine("Is T18 sorted by level: " + IsSortedByLevel(T18));

            // לשאול את טליה למה העץ לא נהרס 


            // שאלות לבוחן של טליה
            // שאלה 1
            // פעולה המקבלת עץ בינארי של מספרים שלמים
            // ומדפיסה רק את הרמות הזוגיות בעץ
            Console.WriteLine("Even levels in T15:");
            PrintEvenLevels(T15);
            Console.WriteLine();

            // שאלה 2
            // פעולה המקבלת עץ בינארי של מספרים שלמים
            // ומדפיסה את סכומי הרמות בעץ
            Console.WriteLine("Sums of levels in T15:");
            PrintLevelsSums(T15);
            Console.WriteLine();

            // שאלה 3
            // פעולה המקבלת עץ בינארי של מספרים שלמים
            // ומדפיסה את ערכו של הצומת הראשון בכל רמה בעץ
            Console.WriteLine("The first node value in each level in T15:");
            PrintFirstInLevels(T15);
            Console.WriteLine();

            // בדיקה לשאלת בגרות בעצים- שאלה 6 - בגרות 2020
            BinNode<int> TT1 = new BinNode<int>(1);
            BinNode<int> TT2 = new BinNode<int>(2);
            BinNode<int> TT3 = new BinNode<int>(3);
            BinNode<int> TT4 = new BinNode<int>(2);
            BinNode<int> TT5 = new BinNode<int>(9);
            BinNode<int> TT6 = new BinNode<int>(5);
            TT1.SetLeft(TT2);
            TT1.SetRight(TT5);
            TT2.SetLeft(TT3);
            TT2.SetRight(TT4);
            TT5.SetRight(TT6);

            PrintAll(TT1);

            // האם כל הצמתים בעץ זוגיים
            Console.WriteLine(IsEven(TT1));

            // בדיקה לשאלת בגרות בעצים - בגרות 2016 ישנה מועד א - שאלה 2
            // דרך קלאסית - דרך ראשונה
            BinNode<int> TR1 = new BinNode<int>(1);
            BinNode<int> TR6 = new BinNode<int>(6);
            BinNode<int> TR3 = new BinNode<int>(3);
            BinNode<int> TR8 = new BinNode<int>(8);
            BinNode<int> TR5 = new BinNode<int>(5);
            BinNode<int> TR4 = new BinNode<int>(4);
            BinNode<int> TR2 = new BinNode<int>(2);
            BinNode<int> TR17 = new BinNode<int>(17);
            BinNode<int> TR19 = new BinNode<int>(19);
            BinNode<int> TR12 = new BinNode<int>(12);
            BinNode<int> TR11 = new BinNode<int>(11);
            BinNode<int> TR10 = new BinNode<int>(10);
            TR1.SetLeft(TR6);
            TR1.SetRight(TR2);
            TR6.SetLeft(TR3);
            TR6.SetRight(TR4);
            TR3.SetRight(TR8);
            TR8.SetLeft(TR5);
            TR2.SetLeft(TR17);
            TR2.SetRight(TR11);
            TR17.SetLeft(TR19);
            TR17.SetRight(TR12);
            TR11.SetRight(TR10);

            Console.WriteLine(RisingPath(TR1));

            // בדיקה לשאלת בגרות בעצים - בגרות 2016 ישנה מועד א - שאלה 2
            // דרך שנייה
            Console.WriteLine(RisingPath2(TR1));

            // בגרות 2022 שאלה 7 - עצים - בדיקה
            BinNode<char> T = new BinNode<char>('h');
            T.SetLeft(new BinNode<char>('n'));
            T.GetLeft().SetLeft(new BinNode<char>('p'));
            T.SetRight(new BinNode<char>('e'));
            T.GetRight().SetRight(new BinNode<char>('l'));
            T.GetRight().GetRight().SetLeft(new BinNode<char>('l'));

            Console.WriteLine(WordFromRoot(T,"hel"));

            // בדיקה לשאלת בגרות 2022 שאלה 4 - מחליפים את השימוש של שרשרת חוליות בתור
            Queue<int> Q = new Queue<int>();
            Q.Insert(-9);
            Q.Insert(-8);
            Q.Insert(-7);
            Q.Insert(12);
            Q.Insert(14);
            Q.Insert(15);
            Queue<Range> Q2 = new Queue<Range>();
            Q2.Insert(new Range(-20, -10));
            Q2.Insert(new Range(-9, 0));
            Q2.Insert(new Range(2, 4));
            Q2.Insert(new Range(12, 12));
            Q2.Insert(new Range(14, 17));

            Console.WriteLine(IsIncluded(Q, Q2));

            // בדיקה לבגרות 2020 מועד ב שאלה 6 - עצים
            BinNode<int> TR01 = new BinNode<int>(9);
            BinNode<int> TR02 = new BinNode<int>(7);
            BinNode<int> TR03 = new BinNode<int>(10);
            BinNode<int> TR04 = new BinNode<int>(11);
            BinNode<int> TR05 = new BinNode<int>(5);
            BinNode<int> TR06 = new BinNode<int>(9);
            TR01.SetLeft(TR02);
            TR01.SetRight(TR03);
            TR03.SetRight(TR04);
            TR02.SetLeft(TR06);
            TR02.SetRight(TR05);

            Console.WriteLine(TreeEqual(TR01));

            // בדיקה לשאלת בגרות 2021 מועד ב שאלה 6 - תור
            Queue<CovidTest> Q1 = new Queue<CovidTest>();
            Q1.Insert(new CovidTest("Tal Shimoni", "1357", 15, true));
            Q1.Insert(new CovidTest("YouSaidYailYouSaidYair", "6969", 69, false));
            Q1.Insert(new CovidTest("Evia", "215666", 15, false));
            Q1.Insert(new CovidTest("AmirGay", "0000", 0, true));
            Q1.Insert(new CovidTest("Liam", "215789", 15, true));
            Q1.Insert(new CovidTest("Hen", "1691", 15, true));

            Console.WriteLine(MostSick(Q1));

            // בדיקה לבגרות 2007 שאלה 3 - עצים בינאריים
            BinNode<int> BT1 = new BinNode<int>(1);
            BinNode<int> BT2 = new BinNode<int>(1);
            BinNode<int> BT3 = new BinNode<int>(1);
            BinNode<int> BT4 = new BinNode<int>(2);
            BinNode<int> BT5 = new BinNode<int>(2);
            BinNode<int> BT6 = new BinNode<int>(1);
            BinNode<int> BT7 = new BinNode<int>(2);
            BT1.SetLeft(BT2);
            BT1.SetRight(BT3);
            BT2.SetLeft(BT4);
            BT2.SetRight(BT5);
            BT3.SetLeft(BT6);
            BT3.SetRight(BT7);

            Console.WriteLine(OnePath(BT1));



        }

    }
}
