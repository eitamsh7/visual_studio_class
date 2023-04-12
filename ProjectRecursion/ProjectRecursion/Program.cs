using System;

namespace ProjectRecursion
{
    class Program
    {
        // טענת כניסה: הפעולה מקבלת מספר שלם חיובי-טבעי
        // טענת יציאה: הפעולה מחשבת באופן רקורסיבי ומחזירה את העצרת של אותו מספר
        public static int Factorial(int N)
        {
            if (N == 0 || N == 1)
                return 1;
            return Factorial(N - 1) * N;
        }

        // שאלה: כתוב פעולה רקורסיבית המקבלת מספר טבעי ומדפיסה את כל המספרים עד המספר שקיבלת
        // טענת כניסה: הפעולה מקבלת מספר טבעי
        // טענת יציאה: הפעולה מדפיסה את כל המספרים עד המספר שקיבלת
        public static void UntilN(int N)
        {
            if (N > 0)
            {
                UntilN(N - 1);
                Console.Write(N + " ");
            }

        }

        //שאלה: כתוב פעולה רקורסיבית המקבלת מספר טבעי ומדפיסה את כל הספרים מאותו מספר שקיבלת עד 1
        // טענת כניסה: הפעולה מקבלת מספר טבעי
        // טענת יציאה: הפעולה מדפיסה את כל הספרים מאותו מספר שקיבלת עד 1
        public static void FromNToOne(int N)
        {
            if (N > 0)
            {
                Console.Write(N + " ");
                FromNToOne(N - 1);
            }

        }

        // שאלה: כתוב פעולה רקורסיבית המקבלת מספר טבעי ומדפיסה את כל המספרים הזוגיים מאחד עד המספר שקיבלת
        // טענת כניסה: הפעולה מקבלת מספר טבעי
        // טענת יציאה: הפעולה  מדפיסה את כל המספרים הזוגיים מאחד עד המספר שקיבלת
        public static void EvenUntilN(int N)
        {
            if (N > 0)
            {
                if (N % 2 == 0)
                    Console.Write(N + " ");
                EvenUntilN(N - 1);
            }
        }

        // שאלות ברקורסיה מעמוד 28-26 לפתור את כל התרגילים במבנה נתונים חוץ מהתרגילים של מערך דו מימדי אותם לא לפתור

        // תרגיל 1- עמוד 26
        // כתוב פעולה רקורסיבית המקבלת מספר טבעי ומחזירה את סכום המספרים השלמים מ-1 עד המספר אותו קיבלנו
        // טענת כניסה: הפעולה מקבלת מספר טבעי
        // טענת יציאה: הפעולה מחזירה את סכום המספרים השלמים מ-1 עד המספר אותו קיבלנו
        public static int SumUntilN(int N)
        {
            if (N == 1)
                return N;
            return SumUntilN(N - 1) + N;

        }

        // תרגיל 1, ב
        // כתוב פעולה רקורסיבית המקבלת מספר טבעי ובודקת כמה מספרים היו בין 1 לאותו מספר שקיבלנו
        // טענת כניסה: הפעולה מקבלת מספר טבעי
        // טענת יציאה: הפעולה בודקת כמה מספרים היו בין 1 לאותו מספר שקיבלנו
        public static int OneBetweenN(int N)
        {
            if (N == 0)
                return N;
            return OneBetweenN(N - 1) + 1;
        }

        // עמוד 26- תרגיל 3
        // כתוב פעולה רקורסיבית המקבלת מספר טבעי ומחזירה את מכפלת המספרים האי זוגיים מ-1 עד המספר שקיבלנו
        // טענת כניסה: הפעולה מקבלת מספר טבעי
        // טענת יציאה: הפעולה מחזירה את מכפלת המספרים האי זוגיים מ-1 עד המספר שקיבלנו
        public static int NotEven(int N)
        {
            if (N == 1)
                return 1;
            if (N % 2 != 0)
                return NotEven(N - 2) * N;
            return NotEven(N - 1);
        }

        // עמוד 26- תרגיל 4
        // כתוב פעולה רקורסיבית המקבלת מספר טבעי ומחזירה את סכום ספרותיו
        // טענת כניסה: הפעולה מקבלת מספר טבעי
        // טענת יציאה: הפעולה מחזירה את סכום ספרותיו
        public static int CountDigit(int N)
        {
            if (N < 10)
                return 1;
            return CountDigit(N / 10) + 1;
        }

        // עמוד 26- תרגיל 5
        // כתוב פעולה רקורסיבית המקבלת שני מספרים שלמים ומחזירה את המנה השלמה שלהם על ידי פעולות חיסור וחיבור בלבד
        // טענת כניסה: הפעולה מקבלת שני מספרים שלמים
        // טענת יציאה: הפעולה מחזירה את המנה השלמה שלהם על ידי פעולות חיסור וחיבור בלבד
        public static int ManaTwoNums(int N1, int N2)
        {
            if (N1 < N2)
                return 0;
            return ManaTwoNums(N1 - N2, N2) + 1;

        }

        // עמוד 26- תרגיל 6
        // כתוב פעולה רקורסיבית המקבלת 2 מספרים שלמים ומחזירה את השארית (האחוז) רק באמצעות חיבור או חיסור
        // טענת כניסה: הפעולה מקבלת 2 מספרים שלמים 
        // טענת יציאה: הפעולה מחזירה את השארית (האחוז) רק באמצעות חיבור או חיסור
        public static int SheeritTwoNums(int N1, int N2)
        {
            if (N1 < N2)
                return N1;
            return SheeritTwoNums(N1 - N2, N2);
        }

        // עמוד 26- תרגיל 7
        // כתוב פעולה רקורסיבית בוליאנית (נכון\לא נכון) המקבלת 2 מספרים שלמים וחיוביים ומחזירה נכון אם איקס כפולה של וואי, אחרת תחזיר לא נכון. יש להיעזר רק בפעולות חיבור וחיסור
        // טענת כניסה: הפעולה מקבלת 2 מספרים שלמים וחיוביים
        // טענת יציאה: הפעולה מחזירה נכון אם איקס כפולה של וואי, אחרת תחזיר לא נכון. יש להיעזר רק בפעולות חיבור וחיסור
        public static bool MulTwoNums(int X, int Y)
        {
            if (X == Y)
                return true;
            if (X > Y)
                return false;
            return MulTwoNums(X, Y - X);
        }

        // עמוד 26 שאלה 9
        // טענת כניסה: הפעולה מקבלת מספר חיובי שלם
        // טענת יציאה: הפעולה מחזירה נכון אם כל הספרות זוגיות, אחרת לא נכון
        public static bool IsEvenDigits(int N)
        {
            //if (N <= 9 && N % 2 == 0)
            //    return true;
            //if (N % 10 % 2 == 0)
            //    return true;
            //return false;
            //return IsEvenDigits(N / 10);
            if (N <= 9)
            {
                if (N % 2 == 0)
                    return true;
                return false;
            }
            if (N % 10 % 2 != 0)
                return false;
            return IsEvenDigits(N / 10);

        }

        // עמוד 26 שאלה 10
        // טענת כניסה: הפעולה מקבלת מספר טבעי
        //  טענת יציאה: הפעולה מחזירה את ערך הביטוי שרשום בשאלה עד המספר שקיבלנו לעיל
        public static int PowerNMul(int N)
        {
            if (N == 1)
                return 2;
            if (N % 2 == 0)
                return PowerNMul(N - 1) + N * N;
            return PowerNMul(N - 1) + N * 2;

        }

        // דרך החיוב
        // טענת כניסה: הפעולה מקבלת מספר טבעי
        // טענת יציאה: הפעולה תחזיר אמת או שקר אם קיימת לפחות ספרה אי-זוגית אחת במספר
        public static bool OneDigitOdd(int N)
        {
            if (N == 0)
                return false;
            if (N % 2 != 0)
                return true;
            return OneDigitOdd(N / 10);
        }

        // דרך השלילה
        // טענת כניסה: הפעולה מקבלת מספר טבעי
        // טענת יציאה: הפעולה תחזיר אמת או שקר אם כל הספרות במספר אי-זוגית  
        public static bool AllDigitOdd(int N)
        {
            if (N == 0)
                return true;
            if (N % 2 == 0)
                return false;
            return OneDigitOdd(N / 10);

        }

        // טענת כניסה: הפעולה מקבלת מספר טבעי
        // טענת יציאה:  מחזירה נכון אם המספר ראשוני, אחרת מחזירה לא-נכון - ניתן להוסיף פרמטרים
        public static bool IsPrime(int N, int i)
        {

            if (N <= i || N == 1 || N == 0)
                return true;
            if (N % i == 0)
                return false;
            return IsPrime(N, i + 1);

        }

        // כתוב פעולה רקורסיבית המקבלת מספר שלם חיובי
        // ומחזירה נכון אם כל הספרות במספר זוגיות או שכל הספרות במספר אי זוגיות
        // ~~~~~~~~~~
        // טענת כניסה: הפעולה מקבלת מספר חיובי שלם
        // טענת יציאה: הפעולה מחזירה נכון אם כל ספרות המספר זוגיות או הכל אי זוגי, אחרת לא נכון
        public static bool ALLEvenOrOdd(int N)
        {
            if (N < 10)
                return true;
            if ((N % 2) != (N / 10 % 2))
                return false;
            return ALLEvenOrOdd(N / 10);
        }

        // עמוד 26 שאלה 11
        // טענת כניסה: הפעולה מקבלת מספר שלם
        // טענת יציאה: הפעולה מחזירה את סכום האיברים הראושונים כמספר הפעמים שקיבלנו בטענת הכניסה
        public static double OddSeriesUntillN(int N) // n = מיקום
        {
            if (N == 1)
                return 1;
            if (N % 2 == 0)
                return OddSeriesUntillN(N - 1) - Math.Sqrt(N * 2 - 1);
            return OddSeriesUntillN(N - 1) + N * 2 - 1;
        }

        // עמוד 26 שאלה 13
        // א
        // טענת כניסה: הפעולה מקבלת מספר של איבר
        // טענת יציאה: הפעולה מחזירה את את ערכו של המספר שקיבלנו בסדרה בה כל איבר בסדרה הוא סכום ריבועי של שני המספרים שלפניו - בסדרה זו 0 הוא האיבר הראשון והשני הוא 1
        public static double SquareSum(int N)
        {
            if (N == 1)
                return 0;
            else if (N == 2)
                return 1;
            return Math.Pow(SquareSum(N - 1), 2) + Math.Pow(SquareSum(N - 2), 2);
        }

        // עמוד 26 שאלה 13 
        // ב
        // טענת כניסה: מקבלת מספר סידורי
        // טענת יציאה: הפעולה מחזירה את סכום האיברים הראשונים בסדרה מהסעיף הקודם, כמספר הפעמים שקיבלנו בטענת הכניסה
        public static double FirstSeries(int N)
        {
            if (N == 1)
                return 0;
            return FirstSeries(N - 1) + SquareSum(N);
        }

        //---------------------------------פעולות רקורסיביות על מערכים---------------------------------

        // טענת כניסה: הפעולה מקבלת מערך ואינדקס של איבר במערך
        // טענת יציאה: הפעולה מחזירה את סכום
        // דרך א:
        public static int SumArr1(int[] Arr, int i)
        {
            if (i == Arr.Length)
                return 0;
            return SumArr1(Arr, i + 1) + Arr[i];
        }

        // דרך ב:
        public static int SumArr2(int[] Arr, int i)
        {
            if (i == -1)
                return 0;
            return SumArr2(Arr, i - 1) + Arr[i];
        }

        // טענת כניסה: הפעולה מקבלת מערך ואינדקס של איבר במערך
        // טענת יציאה: הפעולה מחזירה כמה מספרים זוגיים יש במערך
        public static int CountEven(int[] Arr, int i = 0)
        {
            if (Arr[i] == Arr.Length)
                return 0;
            if (Arr[i] % 2 == 0)
                return CountEven(Arr, i + 1) + 1;
            return CountEven(Arr, i + 1);
        }

        // עמוד 27 שאלה 14
        // טענת כניסה: הפעולה מקבלת מערך ואינדקס של איבר במערך
        // טענת יציאה: הפעולה מחזירה את סכום האיברים במערך מהמקום ה-0 עד המקום של האינדקס
        public static int SumIndexInArr(int[] Arr, int i)
        {
            if (i == 0)
                return Arr[i];
            // או:
            // if (i == -1)
            //return 0;
            return SumIndexInArr(Arr, i - 1) + Arr[i];
        }

        // עמוד 27 שאלה 15
        // טענת כניסה: הפעולה מקבלת מערך ואינדקס של איבר במערך
        // טענת יציאה: הפעולה מחזירה את מספר האיברים החיוביים מתחילת המערך ועד למציין
        public static int PositiveIndexInArr(int[] Arr, int i)
        {
            if (Arr[i] > 0 && i == 0)
                return 1;
            else if (Arr[i] < 0 && i == 0)
                return 0;
            else if (Arr[i] > 0)
                return PositiveIndexInArr(Arr, i - 1) + 1;
            return PositiveIndexInArr(Arr, i - 1);
        }

        // עמוד 27 שאלה 16
        // טענת כניסה: הפעולה מקבלת מערך ומספר שלם כלשהו
        // טענת יציאה: הפעולה מחזירה את מיקומו של המספר במערך, או -1 אם המספר לא נמצא במערך
        public static int NumIndexInArr(int[] Arr, int Num, int i = 0)
        {
            if (i == Arr.Length)
                return -1;
            if (Arr[i] == Num)
                return i;
            return NumIndexInArr(Arr, Num, i + 1);
        }

        // עמוד 27 שאלה 17
        // טענת כניסה: הפעולה מקבלת מערך
        // טענת יציאה: הפעולה בודקת אם אברי המערך ממויינים בסדר עולה, ומחזירה נכון אם כן, או לא נכון אם אחרת
        public static bool AscendingArr(int[] Arr, int i)
        {
            if (i == Arr.Length)
                return true;
            if (Arr[i] > Arr[i - 1])
                return AscendingArr(Arr, i + 1);
            return false;
        }

        //---------------------------------פעולות רקורסיביות עם פעולה עוטפת---------------------------------

        // טענת כניסה: הפעולה מקבלת מערך של שלמים
        // טענת יציאה: הפעולה מחזירה את סכום ספרת האחדות בכל מספר
        public static int SumOnes(int[] Arr)
        {
            return SumOnes(Arr, 0);
        }
        public static int SumOnes(int[] Arr, int i)
        {
            if (i == Arr.Length)
                return 0;
            return SumOnes(Arr, i + 1) + Arr[i] % 10;
        }

        // טענת כניסה: מקבלת מערך של שלמים ומספר שלם נוסף
        // טענת יציאה: הפעולה תחזיר את מיקום המספר אם נמצא אחרת תחזיר מינוס אחד
        public static int NumIndexInArr2(int[] Arr, int Num)
        {
            return NumIndexInArr2(Arr, Num, 0);
        }
        public static int NumIndexInArr2(int[] Arr, int Num, int i)
        {
            if (i == Arr.Length)
                return -1;
            if (Arr[i] == Num)
                return i;
            return NumIndexInArr2(Arr, Num, i + 1);
        }

        // פעולה עוטפת
        // טענת כניסה: הפעולה מקבלת מספר
        // טענת כניסה: הפעולה מחזירה אמת אם המספר ראשוני אחרת שקר
        public static bool IsPrimeNum(int Num)
        {
            return IsPrimeNum(Num, Num - 1);
        }
        // טענת כניסה: הפעולה מקבלת מספר ואינדקס
        // טענת יציאה: הפעולה מחזירה אמת אם המספר ראשוני אחרת שקר
        public static bool IsPrimeNum(int Num, int i = 2)
        {
            if (Num <= i || Num == 1 || Num == 0)
                return true;
            if (Num % i == 0)
                return false;
            return IsPrimeNum(Num, i + 1);
        }
        // שאלה 18 עמוד 27
        // טענת כניסה: הפעולה מקבלת מערך
        // טענת יציאה: הפעולה מחזירה אמת אם אין מספרים ראשוניים במערך אחרת שקר
        public static bool IsPrimeInArr(int[] Arr)
        {
            return IsPrimeInArr(Arr, 0);
        }
        public static bool IsPrimeInArr(int[] Arr, int i)
        {
            if (i == Arr.Length)
                return true;
            if (IsPrimeNum(Arr[i]))
                return false;
            return IsPrimeInArr(Arr, i + 1);
        }

        // שאלה 21 עמוד 27
        // טענת כניסה: הפעולה מקבלת מחרוזת
        // טענת יציאה: הפעולה מחזירה את מספר האותיות האיי-בי-סי הקטנות המופיעות במחרוזת
        public static int abc(string str, int i)
        {
            if (i == str.Length)
                return 0;
            else if (str.ToLower()[i] == str[i] && str[i] == ' ')
                return abc(str, i + 1) + 1;
            return abc(str, i + 1);
        }

        // שאלה 22 עמוד 27
        // טענת כניסה: הפעולה מקבלת מחרוזת
        // טענת יציאה: הפעולה מחזירה מחרוזת חדשה עם התו * כל שלושה תווים
        public static string EveryThree(string Str)
        {
            return EveryThree(Str, 0);
        }
        public static string EveryThree(string Str, int i = 0, string NewStr = "")
        {
            if (i == Str.Length)
                return NewStr;
            else if (i % 3 == 0 && i != 0)
            {
                NewStr += '*';
                EveryThree(Str, i + 1, NewStr);
            }
            NewStr += Str[i];
            return EveryThree(Str, i + 1, NewStr);
        }

        // שאלה 23 עמוד 27
        // טענת כניסה: הפעולה מקבלת מחרוזת
        // טענת יציאה: הפעולה מחזירה את אותה מחרוזת הפוכה
        public static string OppositeString(string Str, int i, string OppositeStr = "")
        {
            if (i == -1)
                return OppositeStr;
            OppositeStr += Str[i];
            return OppositeString(Str, i - 1, OppositeStr);
        }

        // שאלה 24 עמוד 28
        // טענת כניסה: הפעולה מקבלת שתי אותיות קטנות בין איי לזד
        // טענת יציאה: הפעולה מדפיסה את כל האותיות שבינהן
        public static void AToZ(char Start, char End)
        {
            if (Start != End-1)
            {
                Start++;
                Console.WriteLine(Start);
                AToZ(Start, End);
            }
        }

        // שאלה 25 עמוד 28
        // טענת כניסה: הפעולה מקבלת מספר שלם וחיובי
        // טענת יציאה: הפעולה מדפיסה את כל המחלקים של אותו מספר
        public static void DivByN(int N, int i = 1)
        {
            if (i == N)
                Console.WriteLine(N);
            else
            {
                if(N % i == 0)
                    Console.Write(i + ", ");
                DivByN(N, i+1);
            }
        }

        // שאלה 26 עמוד 28
        // טענת כניסה: הפעולה מקבלת מספר שלם
        // טענת יציאה: הפעולה מדפיסה את כל ספרותיו הזוגיות
        public static void EvenDigits(int Num)
        {
            if (Num < 10)
            {
                if (Num % 2 == 0)
                    Console.Write(Num);
            }
            else
            {
                if (Num % 10 % 2 == 0)
                    Console.Write(Num % 10 + " , ");
                EvenDigits(Num / 10);
            }      
        }

        // שאלה 27 עמוד 28
        // טענת כניסה: הפעולה מקבלת שני פרמטרים שיציינו את הערך הנכחי של זוג האינדקסים- הפעולה תזומן עם הערכים 1,1
        // טענת יציאה: הפעולה מדפיסה את לוח הכפל
        public static void MultTable(int x = 1, int y = 1)
        {
            if (x > 10)
            {
                Console.WriteLine();
                MultTable(1, y + 1);
            }
            else if ( y <= 10)
            {
                Console.Write(x * y + " , ");
                MultTable(x + 1, y);
            }
        }

        // טענת כניסה: הפעולה מקבלת מערך עם מספרים שלמים, מספר שלם מין, ומספר שלם מאקס
        // טענת יציאה: הפעולה מדפיסה את כל המספרים בין מין למאקס ותחזיר את סכומם
        public static int PrintNSum(int[] Arr, int Min, int Max)
        {
            return PrintNSum(Arr, Min, Max, 0, 0);
        }
        public static int PrintNSum(int[] Arr, int Min, int Max, int Total, int i)
        {
            if (i == Arr.Length)
                return Total;
            else
            {
                if( Arr[i] > Min && Arr[i] < Max)
                {
                    Console.WriteLine(Arr[i]);
                    Total += Arr[i];
                }
            }
            return PrintNSum(Arr, Min, Max, Total, i + 1);
        }

        // טענת כניסה: הפעולה מקבלת מחרוזת
        // טענת יציאה: הפעולה מחזירה נכון אם היא פולינדרום, אחרת תחזיר לא נכון
        public static bool IsPalindrome(string str)
        {
            return IsPalindrome(str, 0, str.Length-1);
        }
        public static bool IsPalindrome(string str, int i, int j)
        {
            if (i == j || i + 1 == j)
            {
                if (str[i] != str[j])
                    return false;
                return true;
            }  
            else
            {
                if (str[i] != str[j])
                    return false;
            }
            return IsPalindrome(str, i + 1, j - 1);
        }

        //---------------------------------פעולות רקורסיביות עם פעולות על מחרוזות---------------------------------

        // שאלה 21 עמוד 27
        // טענת כניסה: הפעולה מקבלת מחרוזת
        // טענת יציאה: הפעולה מחזירה את מספר האותיות האיי-בי-סי הקטנות המופיעות במחרוזת
        public static int CountLowerletters(string str)
        {
            if (str.Length == 0)
                return 0;
            else if (str[0] >= 'a' && str[0] <= 'z')
                return CountLowerletters(str.Substring(1)) + 1;
            return CountLowerletters(str.Substring(1));
        }

        // שאלה 22 עמוד 27
        // טענת כניסה: הפעולה מקבלת מחרוזת
        // טענת יציאה: הפעולה מחזירה מחרוזת חדשה עם התו * כל שלושה תווים
        public static string WithStars(string str)
        {
            if (str.Length < 3)
                return str;
            return str.Substring(0, 3) + '*' + WithStars(str.Substring(3));
        }
        public static string WithStarsRemove(string str)  
        {
            if (str.Length < 3)
                return str;
            if (str.Length == 3)
                return str + '*';
            return WithStarsRemove(str.Remove(3)) + WithStars(str.Substring(3));
        }

        // שאלת תרגול - חזרה למבחן
        // סעיף א
        // טענת כניסה: הפעולה מקבלת מיקום של סדרה
        // טענת יציאה: הפעולה מחזירה את הערך של הביטוי במיקום שקיבלנו
        public static double SeriesToN(int N)
        {
            if (N == 1)
                return 1;
            if (N % 2 == 0)
                return SeriesToN(N - 1) * 2;
            return SeriesToN(N - 1) / 3 + 1;
        }

        // המשך - סעיף ב
        // טענת כניסה: הפעולה מקבלת מיקום של סדרה
        // טענת יציאה: הפעולה מחזירה את סכום כל האיברי הסדרה- הערכים בו, עד למיקום שקיבלנו
        public static double SeriesSum(int N)
        {
            if (N == 1)
                return 1;
            return SeriesToN(N) + SeriesSum(N - 1);
        }

        // כל שלוש אותיות סימן קריאה
        public static string EveryThreePut(string Str)
        {
            return EveryThreePut(Str, 0);
        }
        public static string EveryThreePut(string Str, int i)
        {
            if (Str.Length <= i)
            {
                return "";
            }
            if (i % 3 == 0 && i != 0)
            {
                return "!" + Str[i] + EveryThreePut(Str, i + 1);
            }
            return Str[i] + EveryThreePut(Str, i + 1);
        }


        // הגדרת הסדרה   
        // עבור מספר זוגי
        // An == (An-1 + An-2)^2 
        // עבור מספר אי זוגי
        // An == An-1/An-2 + 10

        // ערכים נתונים
        // A1 = 1
        // A2 = 3

        // טענת כניסה: הפעולה מקבלת מספר שלם וחיובי
        // טענת יציאה: הפעולה מחזירה את האיבר במקום שקיבלה לפי הגדרת הסדרה
        // ההחנחה היא שהמספר חיובי
        public static double Sidra1(int N)
        {
            if (N == 1)
                return 1;
            else if (N == 2)
                return 3;
            if (N % 2 == 0)
                return Math.Pow((Sidra1(N - 1) + Sidra1(N - 2)), 2);
            return Sidra1(N - 1) / Sidra1(N - 2) + 10;
        }

        // טענת כניסה: הפעולה מקבלת מספר שלם וחיובי
        // טענת יציאה: הפעולה מחזירה את סכום האיברים עד לאיבר במקום שקיבלה כולל
        // ההחנחה היא שהמספר חיובי

        public static double SumSidra1(int N)
        {
            if (N == 1)
                return 1;
            return Sidra1(N) + SumSidra1(N - 1);
        }


        static void Main(string[] args)
        {

            //Console.WriteLine(Factorial(9));
            //Console.WriteLine();
            //UntilN(5);
            //Console.WriteLine();
            //FromNToOne(5);
            //Console.WriteLine();
            //EvenUntilN(9);
            //Console.WriteLine();
            //Console.WriteLine(SumUntilN(9));
            //Console.WriteLine();
            //Console.WriteLine(OneBetweenN(9));
            //Console.WriteLine();
            //Console.WriteLine(NotEven(5));
            //Console.WriteLine();
            //Console.WriteLine(CountDigit(12345));
            //Console.WriteLine();
            //Console.WriteLine(MulTwoNums(2, 10));
            //Console.WriteLine();
            //Console.WriteLine(IsEvenDigits(234));
            //Console.WriteLine();
            //Console.WriteLine(PowerNMul(5));
            //Console.WriteLine(FirstSeries(6));
            //Console.WriteLine(OddSeriesUntillN(4));
            //Console.WriteLine(SquareSum(6));
            //int[] A = { 1, 2, 3, 4, 5, 6, 37 };
            //Console.WriteLine(SumOnes(A));
            //Console.WriteLine(NumIndexInArr2(A, 5));
            ///
            //string Str = "AbCdEfG";
            //Console.WriteLine(abc(Str, 0));
            //Console.WriteLine(EveryThree(Str));
            //Console.WriteLine(OppositeString(Str, Str.Length - 1));
            //// 
            //AToZ('e', 'g');
            //DivByN(16);
            //EvenDigits(8123456);
            //Console.WriteLine("\n");
            //MultTable();
            //// PrintNSum:
            //int[] Arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int Num = PrintNSum(Arr, 3, 9);
            //Console.WriteLine("Total: " + Num);
            ////
            //string Str1 = "AabbaA";
            //Console.WriteLine(IsPalindrome(Str1));
            ////
            Console.WriteLine(CountLowerletters("0"));
            Console.WriteLine(WithStarsRemove("absd"));
            Console.WriteLine(EveryThreePut("ABCDEFG"));

            int N = 5;
            Console.WriteLine();
            Console.WriteLine("An:" + Sidra1(N));
            Console.WriteLine();
            Console.WriteLine("Sn: " + SumSidra1(N));


        }
    }
}
