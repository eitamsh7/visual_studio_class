using ListOfNodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ListOfNodes
{
    internal class AllBirthday
    {
        private Node<Birthday>[] AllBirthdayArr;


        public AllBirthday()
        {
            this.AllBirthdayArr = new Node<Birthday>[12];
            for (int i = 0; i < 12; i++)
            {
                this.AllBirthdayArr[i] = null;
            }
        }

        public void AddBirthday(Birthday Birthday, int Month)
        {
            if (this.AllBirthdayArr[Month - 1] == null)
                this.AllBirthdayArr[Month - 1] = new Node<Birthday>(Birthday);
            else
            {
                Node<Birthday> PosBirthdayArr = this.AllBirthdayArr[Month - 1];
                while (PosBirthdayArr.GetNext() != null)
                {
                    PosBirthdayArr = PosBirthdayArr.GetNext();
                }
                PosBirthdayArr.SetNext(new Node<Birthday>(Birthday));
            }
        }

        public void RemoveBirthday(Birthday Birthday, int Month)
        {
            if (this.AllBirthdayArr[Month - 1] != null)
            {
                Node<Birthday> PosBirthdayArr = this.AllBirthdayArr[Month - 1];
                Node<Birthday> PrevPos = null;
                while (PosBirthdayArr != null)
                {
                    if (PosBirthdayArr.GetValue() == Birthday)
                    {
                        if (PrevPos == null)
                        {
                            this.AllBirthdayArr[Month - 1] = this.AllBirthdayArr[Month - 1].GetNext();
                            PosBirthdayArr = this.AllBirthdayArr[Month - 1];
                        }
                        else
                        {
                            PrevPos.SetNext(PosBirthdayArr.GetNext());
                            PosBirthdayArr = PosBirthdayArr.GetNext();
                        }
                    }
                    else
                    {
                        PrevPos = PosBirthdayArr;
                        PosBirthdayArr = PosBirthdayArr.GetNext();
                    }
                }
            }
        }

        public int MaxBirthday()
        {
            int Max = 0;
            int Month = 1;
            for (int i = 0; i < this.AllBirthdayArr.Length; i++)
            {
                Node<Birthday> PosBirthdayArr = this.AllBirthdayArr[i];
                int Count = 0;
                while (PosBirthdayArr != null)
                {
                    Count++;
                    PosBirthdayArr = PosBirthdayArr.GetNext();
                }
                if (Count > Max)
                {
                    Max = Count;
                    Month = i + 1;
                }
            }
            return Month;
        }

        public override string ToString()
        {
            string S = "";
            for (int i = 0; i < 12; i++)
            {
                Node<Birthday> PosBirthday = this.AllBirthdayArr[i];
                while (PosBirthday != null)
                {
                    S += PosBirthday.ToString() + "\n";
                    PosBirthday = PosBirthday.GetNext();
                }
            }
            return S;
        }



    }

}
