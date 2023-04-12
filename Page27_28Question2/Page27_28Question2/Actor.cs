using System;
using System.Collections.Generic;
using System.Text;

namespace Page27_28Question2
{
    class Actor
    {
        private int ID; // מספר תז של השחקן
        private string Gender; // מין השחקן
        private int NumFilms; // מספר הסרטים שבהם השחקן השתתף
        private string Name; // שם השחקן

        // פעולה בונה
        public Actor(string Name, int ID, string Gender, int NumFilms)
        {
            this.Name = Name;
            this.ID = ID;
            if (Gender == "M")
                this.Gender = "M";
            this.Gender = "F";
            this.NumFilms = NumFilms;
        }

        public int GetID()    // פעולה המחזירה את מספר הסרטים שהשחקן השתתף בהם
        {
            return this.ID;
        }

        public int GetNumFilms()    // פעולה המחזירה את מספר הסרטים שהשחקן השתתף בהם
        {
            return this.NumFilms;
        }

        // פעולה אשר מוסיפה סרטים לשחקן
        public void AddFilm()
        {
            this.NumFilms++;
        }

        public int Compare(Actor Other) // פעולה משווה
        {
            if (this.NumFilms > Other.NumFilms)
                return 1;
            else if (this.NumFilms < Other.NumFilms)
                return 2;
            return 3;
        }

        public override string ToString() // פעולה מתארת
        {
            return "\n" + "Name: " + this.Name + ", ID: " + this.ID + ", Geder: " + this.Gender + ", Actor Num of Films part in: " + this.NumFilms;
        }

    }
}
