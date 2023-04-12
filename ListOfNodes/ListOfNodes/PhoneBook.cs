using System;
using System.Collections.Generic;
using System.Text;

namespace ListOfNodes
{
    class PhoneBook
    {
        private Node<Contact> ListOfContact;  // Contact שרשרת של אובייקטים מטיפוס

        public PhoneBook()
        {
            this.ListOfContact = null;
        }

        public Node<Contact> IsExist(Contact C) // הפעולה מקבלת איש קשר ובדוקת האם הוא נמצא בשרשרת ומחזירה הפנייה
        {
            Node<Contact> Pos = this.ListOfContact;
            while (Pos != null)
            {
                if (Pos.GetValue().GetPhoneNumber().Equals(C.GetPhoneNumber()))
                {
                    return Pos;
                }
                Pos = Pos.GetNext();
            }
            return Pos;
        }

        public void AddFirst(Contact C)  // הוספת חוליה אם היא לא קיימת אל ההתחלה
        {
            Node<Contact> Pos = IsExist(C);
            if (Pos != null)
            {
                this.ListOfContact = new Node<Contact>(C, this.ListOfContact);
            }
        }

        public void AddLast(Contact C)  // הוספת חוליה אם היא לא קיימת אל הסוף
        {
            Node<Contact> Pos = this.ListOfContact;

            if(IsExist(C) == null)
            {
                if(this.ListOfContact == null)
                {
                    this.ListOfContact = new Node<Contact>(C);
                }
                else
                {
                    while(Pos.GetNext() != null)
                    {
                        Pos = Pos.GetNext();
                    }
                    Pos.SetNext(new Node<Contact>(C));
                }
            }
            
        }

         public void Remove(Contact C) // הסרת חולייה מהשרשרת
        {
            if(IsExist(C) != null)
            {
                Node<Contact> Pos = this.ListOfContact;
                if(this.ListOfContact == Pos)
                {
                    this.ListOfContact = ListOfContact.GetNext();
                }
                else
                {
                    while (Pos.GetNext() != Pos)
                    {
                        Pos = Pos.GetNext();
                    }
                    Pos.SetNext(Pos.GetNext());
                }
            }
            
        }

        public override string ToString() // פעולה מתארת
        {
            Node<Contact> Pos = this.ListOfContact;
            string S = "";
            while (Pos != null)
            {
                S += Pos.GetValue() + "\n";
                Pos = Pos.GetNext();
            }
            return S;
        }

    }
}
