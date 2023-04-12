using System;
using System.Collections.Generic;
using System.Text;

namespace ListOfNodes
{
    class BusRoute
    {
        private Node<Station> ListOfStation; // שרשרת חוליות מטיפוס תחנה

        public BusRoute(Station S1, Station S2)
        {
            this.ListOfStation = new Node<Station>(S1);
            this.ListOfStation.SetNext(new Node<Station>(S2));
        }

        public void AddStation(Station NewStation) // הוספת תחנה לסוף
        {
            Node<Station> Pos = this.ListOfStation;
            while (Pos.GetNext() != null)
                Pos = Pos.GetNext();
            Pos.SetNext(new Node<Station>(NewStation));
        }

        public double RouteLen()  // חישוב מסלול
        {
            double Len = 0;
            Node<Station> Pos = this.ListOfStation;
            while (Pos.GetNext() != null)
            {
                Len += Pos.GetValue().Distance(Pos.GetNext().GetValue());
                Pos = Pos.GetNext();
            }
            return Len;
        }

        public override string ToString()
        {
            string S = ""; 
            Node<Station> Pos = this.ListOfStation;
            while(Pos != null)
            {
                S += Pos.GetValue();
                Pos = Pos.GetNext();
            }
            S += "/n";
            return S;
        }
    }
}
