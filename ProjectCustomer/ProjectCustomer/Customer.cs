using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectCustomer
{
    class Customer
    {
        private string Name; // שם הלקוח
        private string TellNum; // מספר הטלפון של הלקוח

        public Customer(string Name, string TellNum) // פעולה בונה
        {
            this.Name = Name;
            this.TellNum = TellNum;
        }

        // פעולה מאחזרת
        public string GetName()
        {
            return this.Name;
        }

        // פעולה מאחזרת
        public string GetTellNum()
        {
            return this.TellNum;
        }

        // פעולה מעדכנת
        public void SetName(string Name)
        {
            this.Name = Name;
        }

        // פעולה מעדכנת
        public void SetTellNum(string TellNum)
        {
            this.TellNum = TellNum;
        }

        public override string ToString() // פעולה מתארת
        {
            return "Customer Name " + Name + "Customer TellNum " + TellNum;
        }
    }
}
