using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectQueue
{
    class CovidTest
    {
        private string Name; // שם הנבדק
        private string ID; // ת.ז הנבדק
        private int CityCode; // קוד עיר מגורי הנבדק
        private bool Sick; // האם הנבדק חולה

        public CovidTest(string Name, string ID, int CityCode, bool Sick) // פעולה בונה
        {
            this.Name = Name;
            this.ID = ID;
            this.CityCode = CityCode;
            this.Sick = Sick;
        }

        // פעולות מאחזרות
        public int GetCityCode()
        {
            return this.CityCode;
        }
        public bool GetSick()
        {
            return this.Sick;
        }


    }
}
