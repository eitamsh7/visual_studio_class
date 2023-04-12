using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTexi
{
    class Texi
    {
        private string TexiID; // מספר רישוי של הרכב
        private string DriverName; // שם הנהג
        private int NumPass; // מספר הקומות לנוסעים ברכב
        private bool IsAvailable; // האם המונית פנויה

        public Texi(string TexiID, string DriverName, int NumPass) // פעולה בונה
        {
            this.TexiID = TexiID;
            this.DriverName = DriverName;
            this.NumPass = NumPass;
            this.IsAvailable = true;
        }

        // פעולות מאחזרות
        public string GetTexiID()
        {
            return this.TexiID;
        }

        public int GetNumPass()
        {
            return this.NumPass;
        }

        public bool GetIsAvailable()
        {
            return this.IsAvailable;
        }

        public void TexiBusy() // פעולה המעדכנת את המונית להיות לא פנויה
        {
            this.IsAvailable = false;
        }

        public override string ToString() // פעולה מתארת
        {
            return "[" + "TexiID: " + this.TexiID + ", DriverName: " + this.DriverName + ", NumPass: " 
                + this.NumPass + ", IsAvailable- True/False: " + this.IsAvailable + "]" + "\n";
        }
    }
}
