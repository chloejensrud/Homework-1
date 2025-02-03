// Written By Chloe Jensrud 
// 2/1/25


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FourSisters
{
    public class EggsGathered
    {
        //Class Variables
        private int totalEggs = -1;
        private int eggsPerSister = -1;
        private int leftoverEggs = -1;


        //gets and sets
        public int TotalEggs
        {
            get { return this.totalEggs; }
            set { this.totalEggs = value; }
        }
        public int EggsPerSister
        {
            get { return this.eggsPerSister; }
            set { this.eggsPerSister = value; }
        }
        public int LeftoverEggs
        {
            get { return this.leftoverEggs; }
            set { this.leftoverEggs = value; }
        }
        
        // FUll COnstructor
        public EggsGathered(int aTotalEggs)
            {
            this.TotalEggs = aTotalEggs;

            }
        //Method
        public int CalcEggsPerSister()
        {
            int eggsPerSister = 0;

            eggsPerSister = (this.TotalEggs / 4);

            return eggsPerSister; 
        }
        public int CalcLeftovers()
        {
            int leftoverEggs = 0;

            leftoverEggs = this.TotalEggs % 4;

            return leftoverEggs;
        }

    
    }
}