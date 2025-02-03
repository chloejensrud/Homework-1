//Written By Chloe Jensrud
//2/1/25


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionOfKings
{
    //Class Variables
    public class Kingdom
    {
        private int provinces = -1;
        private int duchies = -1;
        private int estates = -1;
    
    //Gets and Sets
    public int Provinces
        { get { return this.provinces; }
            set { this.provinces = value; }
        }
    public int Duchies
        {
            get { return this.duchies; }
            set { this.duchies = value; }
        }
    public int Estates
        {
            get { return this.estates; }
            set { this.estates = value; }
        }
    //Constructor
    public Kingdom(int aProvinces, int aDuchies, int aEstates)
        {
            this.provinces = aProvinces;
            this.duchies = aDuchies;
            this.estates = aEstates;
        }
    //Method
    public int CalcTotal()
        {
            int totalScore = (this.provinces * 6) + (this.duchies * 3) + (this.estates * 1);
            return totalScore;
        }

    } 
}

