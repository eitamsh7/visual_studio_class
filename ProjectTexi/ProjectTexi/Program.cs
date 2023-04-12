using System;

namespace ProjectTexi
{
    class Program
    {

        // "טענת כניסה: הפעולה מקבלת מספר נוסעים ועצם מטיפוס "תחנת מוניות
        // טענת יציאה: הפעולה מחזירה מחרוזת שמציינת את מספר הרישוי של המונית הפנויה הראשונה במערך ומעדכנת אותה לתפוסה
        public static string FindTexi(TexiStation TS, int Pass)
        {
            for (int i = 0; i < TS.GetNumOfTexies(); i++)
            {
                if (TS.GetTexiArr()[i].GetIsAvailable() && TS.GetTexiArr()[i].GetNumPass() >= Pass)
                {
                    TS.GetTexiArr()[i].TexiBusy();
                    return TS.GetTexiArr()[i].GetTexiID() + "\n";
                }
            }
            return "Can't find a texi!";
        }

        static void Main(string[] args)
        {
            Texi T1 = new Texi("123", "Shaul", 5);
            Texi T2 = new Texi("456", "Yohi", 4);
            Texi T3 = new Texi("789", "Sini", 3);
            Texi T4 = new Texi("901", "Yair", 2);

            TexiStation TS1 = new TexiStation("SINOSOTROS");
            TS1.AddTexi(T1);
            TS1.AddTexi(T2);
            TS1.AddTexi(T3);
            TS1.AddTexi(T4);

            Console.WriteLine(TS1);
            Console.WriteLine(FindTexi(TS1, 4));
            Console.WriteLine(TS1);

        }
    }
}
