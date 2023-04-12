using System;
using System.Collections.Generic;
using System.Text;

namespace Page24question2
{
    internal class Country
    {
        private string CountryName; //שם המדינה
        private Game[] Games; //מערך המכיל את המשחקים שהמדינה משתתפת בהם
        private int NumOfGames; //כמות המשחקים במערך בפועל

        //פעולה בונה
        public Country(string CountryName)
        {
            this.Games = new Game[43];
            this.CountryName = CountryName;
            this.NumOfGames = 0;

            for (int i = 0; i < this.Games.Length; i++)
            {
                this.Games[i] = null;
            }
        }

        //פעולה המקבלת את שם המשחק ומחזירה האם המדינה שמתתפת בו
        public bool IsParticipate(string GameName)
        {
            for (int i = 0; i < this.NumOfGames; i++)
            {
                if (this.Games[i].GetGameName() == GameName)
                {
                    return true;
                }
            }
            return false;
        }

        //פעולה הבודקת האם המשחק נמצא במערך ומחזירה את האינדקס שלו
        public int IsExist(Game Game)
        {
            for (int i = 0; i < this.NumOfGames; i++)
            {
                if (this.Games[i].GetGameName() == Game.GetGameName())
                {
                    return i;
                }
            }
            return -1;
        }

        //פעולה המוסיפה משחק למערך אם הוא לא נמצא בה
        public void AddGame(Game GameToAdd)
        {
            if (IsExist(GameToAdd) == -1 && NumOfGames < Games.Length) //אם המשחק לא קיים ויש מקום במערך
            {
                this.Games[NumOfGames] = GameToAdd; //הוספת משחק למערך
                this.NumOfGames++; //קידום כמות המשחקים בפועל
            }
        }

        // פעולה המוציאה משחק מהמערך אם הוא נמצא בה
        public void RemoveGame(Game GameToRemove)
        {
            int IndexToRemove = IsExist(GameToRemove);
            Game[] NewGameArr = new Game[Games.Length - 1]; //מערך שישמש כדיי לאחסן משחקים שלא השתנו ולהוציא את המשחק שצריך
            int k = 0; //אינדקס למערך החדש
            if (IndexToRemove != -1) //אם המשחק קיים - גדול או שונה ממינוס 1
            {
                for (int i = 0; i < this.Games.Length; i++)
                {
                    if (this.Games[i] != GameToRemove)
                    {
                        NewGameArr[k] = this.Games[i];
                        k++;
                    }
                }
                this.NumOfGames--; //הורדת מספר המשחקים ב1
            }
            this.Games = NewGameArr; //דריסת המערך הישן במערך המעודכן
        }

        //פעולה מתארת
        public override string ToString()
        {
            string S = "";
            S += "Country Name: " + CountryName + "\n";
            for (int i = 0; i < this.Games.Length; i++)
            {
                S += this.Games[i] + " ";
            }
            S += "\n" + "Number of games: " + this.NumOfGames + "\n";
            return S;
        }
    }
}
