using System;
using System.Collections.Generic;
using System.Text;

namespace ListOfNodes
{
    class Contact
    {
        private string Name; // שם
        private string Tel; // מספר טלפון

        public Contact(string Name, string Tel)
        {
            this.Name = Name;
            this.Tel = Tel;
        }

        public string GetName()
        {
            return this.Name;
        }

        public string GetPhoneNumber()
        {
            return this.Tel;
        }

        public override string ToString()
        {
            return "Name: " + Name + "Tel: " + Tel;
        }
    }
}
