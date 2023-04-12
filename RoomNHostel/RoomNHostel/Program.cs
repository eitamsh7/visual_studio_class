using System;

namespace RoomNHostel
{
    class Program
    {
        // טענת כניסה: הפעולה מקבלת אובייקט מטיפוס הוסטל
        // טענת יציאה: הפעולה מחזירה את כל החדרים הזוגיים - מהטיפוס הזוגי, בקומה 3
        public static int CountDoubleInFloor3(Hostel H)
        {
            int Count = 0;
            for (int i = 0; i < H.GetNumOfRooms(); i++)
            {
                if (H.GetAllRooms()[i].GetRoomNum() / 100 == 3 && H.GetAllRooms()[i].GetRoomType() == 2)
                    Count++;
            }
            return Count;
        }
        static void Main(string[] args)
        {
            Room R1 = new Room(123, 2, 5);
            Room R2 = new Room(223, 2, 5);
            Room R3 = new Room(341, 2, 5);
            Room R4 = new Room(123, 2, 5);
            Room R5 = new Room(123, 2, 5);
            Room R6 = new Room(367, 1, 5);

            Hostel H1 = new Hostel();
            H1.AddRoom(R1);
            H1.AddRoom(R2);
            H1.AddRoom(R3);
            H1.AddRoom(R4);
            H1.AddRoom(R5);
            H1.AddRoom(R6);
            Console.WriteLine(H1);

            // קריאה לפעולה פנימית
            Console.WriteLine(H1.CountDoubleInFloor3());

            // קריאה לפעולה פנימית במחלקת הוסטל
            Console.WriteLine(CountDoubleInFloor3(H1));

            // למחוק חדר מהמערך
            H1.DeleteRoom1(R2);
            Console.WriteLine(H1);



            //Console.WriteLine("==============================");
            //Room[] NewArr = H1.IsEvenThirdFloor();

            
        }
    }
}
