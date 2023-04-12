using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectStudent
{
    class ClassStudent
    {
        private string Name;
        private double Ave;

        // פעולה בונה
        public ClassStudent(string Name, double Ave)
        {
            this.Name = Name;
            this.Ave = Ave;
        }

        // פעולות מאחזרות: 
        public string GetName()
        {
            return this.Name;
        }
        public double GetAve()
        {
            return this.Ave;
        }

        // פעולה מעדכנת\קובעת: 
        public void SetName(string Name)
        {
            this.Name = Name;
        }
        public void SetAve(double Ave)
        {
            this.Ave = Ave;
        }

        // פעולה מתארת: הפעולה מחזירה מחרוזת שתכיל את המאפיינים 
        public override string ToString()
        {
            return "Name:" + this.Name + " , " + "Ave:" +this.Ave;
        }
    }
}
