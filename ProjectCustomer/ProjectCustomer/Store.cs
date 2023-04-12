using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectCustomer
{
    class Store
    {
        private Customer[] CustomersArr; // מערך של לקוחות
        private int Current; // כמות הלקוחות בפועל

        // פעולה מאחזרת
        public Customer[] GetCustomersArr()
        {
            return this.CustomersArr;
        }

        // פעולה מאחזרת
        public int GetCurrent()
        {
            return this.Current;
        }

        public Store() // פעולה בונה
        {
            this.Current = 0;
            this.CustomersArr = new Customer[100];
            for (int i = 0; i < this.CustomersArr.Length; i++)
            {
                this.CustomersArr[i] = null;
            }
        }

        // הפעולה מקבלת לקוח ומחזירה את האינדקס שלו במערך אם הוא נמצא, אחרת מחזירה מינוס 1
        public int IsCustomerExist(Customer Customer)
        {
            for (int i = 0; i < this.Current; i++)
            {
                if (this.CustomersArr[i].GetTellNum() == Customer.GetTellNum())
                    return i;
            }
            return -1;
        }

        // הפעולה מקבלת לקוח ומוסיפה אותו למערך
        public void AddCustomer(Customer Customer)
        {
            if(this.Current < this.CustomersArr.Length && IsCustomerExist(Customer) == -1)
            {
                this.CustomersArr[this.Current] = Customer;
                this.Current++;
            }
        }

        // הפעולה מקבלת לקוח ומוחקת אותו מהמערך
        public void DeleteCustomer1(Customer Customer)
        {
            int CustomerIndex = IsCustomerExist(Customer);
            if ( IsCustomerExist(Customer) == CustomerIndex)
            {
                this.CustomersArr[CustomerIndex] = null;
                this.Current--;
            }
        }

        // הפעולה מקבלת לקוח ומוקחת אותו מהמערך אם קיים כבר במערך

        public void DeleteCustomer2(Customer Customer)
        {
            int CustomerIndex = IsCustomerExist(Customer);
            if (CustomerIndex != -1)
            {
                for (int i = CustomerIndex; i < this.Current - 1; i++)
                {
                    this.CustomersArr[i] = this.CustomersArr[i + 1];
                }
                this.CustomersArr[this.Current] = null;
                this.Current--;
            }
        }



    }
}
