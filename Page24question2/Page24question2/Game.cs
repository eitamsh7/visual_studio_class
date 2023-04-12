using System;
using System.Collections.Generic;
using System.Text;

namespace Page24question2
{
    internal class Game
    {
        private string GameName; //שם המשחק
        private int NumPlayers; //מספר השחקנים
        private bool IsWater; //אם המשחק מתקיים במים

        //פעולה בונה
        public Game(string GameName, int NumPlayers, bool IsWater)
        {
            this.GameName = GameName;
            this.NumPlayers = NumPlayers;
            this.IsWater = IsWater;
        }

        //מחזיר את שם המשחק
        public string GetGameName()
        {
            return this.GameName;
        }

        //משנה את שם המשחק
        public void SetGameName(string GameName)
        {
            this.GameName = GameName;
        }

        //פעולה מתארת
        public override string ToString()
        {
            return "\n" + "Game name: " + GameName + "\nThe number of players: " + NumPlayers + "\nIs water: " + IsWater;
        }
    }
}
