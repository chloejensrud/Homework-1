//Written By Chloe Jensrud
//2/1/25


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefenseSystems
{
    public class DefenseSystems
    {
        //Class Variables
        private int targetRow = -1;
        private int targetCol = -1;

        //gets and sets
        public int TargetRow
        {
            get { return targetRow; }
            set { targetRow = value; }
        }
        public int TargetCol
        { get { return targetCol; } 
          set { targetCol = value; } 
        }
       
        //Constructor
        public CalcDeploy(int aTargetRow, int aTargetCol)
        {
            this.targetRow = aTargetRow;
            this.targetCol = aTargetCol;

            Console.WriteLine("Deploy to:");
            for (int i = 0; i < targetRow; i++)
            {

                int deployRow = targetRow;
                int deployCol = targetCol;


            }
        }





    }
}
