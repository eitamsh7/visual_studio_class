namespace RoomNHostel
{
    class Hostel
    {
        private Room[] AllRooms; // מערך של חדרים
        private int NumOfRooms; // מספר החדרים בפועל

        // פעולה בונה
        public Hostel()
        {
            this.AllRooms = new Room[200];
            for (int i = 0; i < this.AllRooms.Length; i++)
            {
                this.AllRooms[i] = null;
            }
            this.NumOfRooms = 0;
        }

        // פעולה מאחזרת
        // שליפת המערך
        public Room[] GetAllRooms()
        {
            return this.AllRooms;
        }

        // פעולה מאחזרת
        // שליפת מספר החדרים התפוסים
        public int GetNumOfRooms()
        {
            return this.NumOfRooms;
        }

        // בדיקת חדר אם תפוס, הפעולה מחזירה טרו אם החדר במערך ופולס אם החדר לא בערך
        public bool IsExist(Room R)
        {
            for (int i = 0; i < this.NumOfRooms; i++)
            {
                if (this.AllRooms[i].GetRoomNum() == R.GetRoomNum())
                    return true;
            }
            return false;
        }

        // הפעולה מחזירה את המיקום במערך, האינדקס של התא אם מצאנו, אחרת הפעולה תחזיר מינוס אחד 
        public int IsExist1(Room R)
        {
            for (int i = 0; i < this.NumOfRooms; i++)
            {
                if (this.AllRooms[i].GetRoomNum() == R.GetRoomNum())
                    return i;
            }
            return -1;
        }

        // הוספת חדר למערך
        public void AddRoom(Room R)
        {
            if (this.NumOfRooms < AllRooms.Length && !this.IsExist(R))
            {
                this.AllRooms[this.NumOfRooms] = R;
                this.NumOfRooms++;
            }
        }

        // הפעולה מחזירה את כל החדרים הזוגיים שנמצאים בקומה מספר שלוש
        public Room[] IsEvenThirdFloor()
        {
            int Count = 0;
            for (int i = 0; i < this.NumOfRooms; i++)
            {
                if(AllRooms[i].GetRoomNum() / 100 == 3 && this.AllRooms[i].GetRoomType() == 2)
                {
                    Count++;
                }
            }
            int J = 0;
            Room[] NewRoomArr = new Room[Count];
            for (int i = 0; i < this.NumOfRooms; i++)
            {
                if (AllRooms[i].GetRoomNum() / 100 == 3 && AllRooms[i].GetRoomNum() == 2)
                {
                    NewRoomArr[J] = AllRooms[i];
                    J++;
                }
            }
            return NewRoomArr;
        }

        // פעולה המחזירה את כמות החדרים התפוסים מטיפוס זוגי - 2, שהקומה היא מספר 3
        public int CountDoubleInFloor3()
        {
            int Count = 0;
            for (int i = 0; i < this.NumOfRooms; i++)
            {
                if (AllRooms[i].GetRoomNum() / 100 == 3 && AllRooms[i].GetRoomType() == 2)
                    Count++;
            }
            return Count;
        }

        // מחיקת חדר מהאוסף, ושמירה על סדר המערך- יש משמעות לסדר המערך. שמירה ללא רווחים
        public void DeleteRoom1(Room R)
        {
            int Place = this.IsExist1(R);
            if(Place != -1)
            {
                for (int i = Place; i < this.NumOfRooms -1; i++)
                {
                    this.AllRooms[i] = this.AllRooms[i + 1];
                }
                this.AllRooms[NumOfRooms - 1] = null;
                NumOfRooms--;
            }
        }

        // מחיקת חדר מהאוסף, אין משמעות לסדר המערך. שמירה ללא רווחים
        public void DeleteRoom2(Room R)
        {
            int Place = this.IsExist1(R);
            if (Place != -1)
            {
                this.AllRooms[Place] = this.AllRooms[NumOfRooms - 1];
                this.AllRooms[NumOfRooms - 1] = null;
                NumOfRooms--;
            }
        }

        // מחיקת חדר מהמערך
        public void RemoveRoom(Room RoomToOut)
        {
            Room[] NewRoomArr = new Room[AllRooms.Length];
            int k = 0;
            if (IsExist(RoomToOut)) // בודקים האם השחקן שאנו רוצים להעיף נמצא כבר במערך
            {
                for (int i = 0; i < this.AllRooms.Length; i++)
                {
                    if (AllRooms[i] != RoomToOut) // אם השחקן שאנו רוצים להעיף לא נמצא נמצא במיקום הספציפי שבו אנו נמצאים במערך נרצה להעביר למערך החדש את אותו שחקן באותו מיקום מהמערך הישן
                    {
                        NewRoomArr[k] = AllRooms[i];
                        k++;
                    }
                    this.NumOfRooms--; // הורדת מספר השחקנים שזכו באחד
                }
                this.AllRooms = NewRoomArr; // דריסת המערך הישן על ידי המערך החדש - ללא השחקן אותו העפנו
            }
        }

        // פעולה מתארת
        public override string ToString()
        {
            string S = "";
            for (int i = 0; i < this.NumOfRooms; i++)
            {
                S += this.AllRooms[i].ToString() + "\n" + "\n";
            }
            return S;
        }
    }
}
