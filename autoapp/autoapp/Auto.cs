using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoapp
{
    internal class Auto
    {
        public int sorszam;
        public string marka;
        public string nev;
        public int gyartev;
        public string szin;
        public int eladott;
        public int atlagos;
        public Auto(string sor) 
        {
            string[]vag= sor.Split(';');
            this.atlagos= int.Parse(vag[0]);
            this.marka= vag[1];
            this.nev= vag[2];
            this.gyartev=int.Parse(vag[3]);
            this.szin= vag[4];
            this.eladott= int.Parse(vag[5]);
            this.atlagos = int.Parse(vag[6]);
            
        }
    }
}
