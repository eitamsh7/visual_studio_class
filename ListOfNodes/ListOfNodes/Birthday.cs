using System;
using System.Collections.Generic;
using System.Text;

namespace ListOfNodes
{
    class Birthday
    {
        private string Name;
        private int Day;

        public Birthday(string Name, int Day)
        {
            this.Name = Name;
            this.Day = Day;
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Day: " + Day + "\n";
        }
    }
}
