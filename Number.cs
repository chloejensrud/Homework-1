//Written By Chloe Jensrud
// 2/1/25


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clocktower
{
    public class Number
    {
        //Class Varibales
        private int clockNumber = 0;

        //Gets and Sets
        public int ClockNumber
        {
            get { return this.clockNumber; }
            set { this.clockNumber = value; }
        }
        //Constructor
        public Number(int aClockNumber)
        { this.ClockNumber = aClockNumber; }

        //Method
        public string CalcEvenOrOdd()
        {
            if (clockNumber % 2 == 0)
            {
                return "Tik";
            }
            else
            {
                return "Tock";
            }



        }
    } 
}
