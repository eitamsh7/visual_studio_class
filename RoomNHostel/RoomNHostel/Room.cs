using System;
using System.Collections.Generic;
using System.Text;

namespace RoomNHostel
{
    class Room
    {
        private int RoomNum; // מספר החדר
        private int RoomType; // סוג החדר- יחיד או זוגי
        private int NightsReserved; // מספר הלילות שהחדר פנוי 

        // פעולה בונה
        public Room(int RoomNum, int RoomType, int NightsReserved)
        {
            this.RoomNum = RoomNum;
            this.RoomType = RoomType;
            this.NightsReserved = NightsReserved;
        }

        // פעולה הבודקת את מספר הקומה ומחזירה 0 במידה והקלט לא תקין
        public int FloorExist()
        {
            if (RoomNum >= 100 && RoomNum <= 399)
                return this.RoomNum / 100;
            return 0;
        }

        // שליפת מספר החדר
        public int GetRoomNum()
        {
            return this.RoomNum;
        }

        // שליפת סוג החדר - יחיד או זוגי
        public int GetRoomType()
        {
            return this.RoomType;
        }

        // חישוב המחיר הכללי שיש לשלם
        public int Income()
        {
            if (this.RoomType == 1)
                return this.NightsReserved * 50;
            return this.NightsReserved * 100;

        }

        // פעולה מתארת
        public override string ToString()
        {
            return this.RoomNum + " " + this.RoomType + " " + this.NightsReserved;
        }
    }
}
