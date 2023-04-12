using System;
using System.Collections.Generic;
using System.Text;

namespace FarmManagement
{
    class Tree
    {
        private string TreeName; // שם העץ
        private int TreeCode; // קודה העץ
        private int TreeCountPicked; // כמות הפירות שנקטפו מעץ זה בשנה האחרונה

        public Tree(string TreeName, int TreeCode, int TreeCountPicked) // פעולה בונה
        {
            this.TreeName = TreeName;
            this.TreeCode = TreeCode;
            this.TreeCountPicked = TreeCountPicked;
        }

        // ~~~~~~~~~~~~~~~~~~~~~~ פעולות מאחזרות ומעדכנות ~~~~~~~~~~~~~~~~~~~~~~
        public string GetTreeName()
        {
            return this.TreeName;
        }
        public int GetTreeCode()
        {
            return this.TreeCode;
        }
        public int GetTreeCountPicked()
        {
            return this.TreeCountPicked;
        }

        public void SetTreeName(string TreeName)
        {
            this.TreeName = TreeName;
        }
        public void SetTreeCode(int TreeCode)
        {
            this.TreeCode = TreeCode;
        }
        public void SetTreeCountPicked(int TreeCountPicked)
        {
            this.TreeCountPicked = TreeCountPicked;
        }

        // פעולה מתארת
        public override string ToString()
        {
            return "\n" + "Tree Name: " + this.TreeName + "    " + "Tree Code: " + this.TreeCode + "    " + "Tree Count Picked: " + this.TreeCountPicked;
        }

    }
}
