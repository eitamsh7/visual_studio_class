using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProg
{
    class CovidTest // בניית מחלקה - שאלת בגרות 2021 מועד ב שאלה 6
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
        public string GetName()
        {
            return this.Name;
        }
        public string GetID()
        {
            return this.ID;
        }
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
