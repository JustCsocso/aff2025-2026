using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuggohidak
{
    internal class Fuggohid
    {
        public int helyezes;
        public string nev;
        public string fhely;
        public string orszag;
        public int hossz;
        public int ev;

        public Fuggohid(string sor)
        {
            string[] vag= sor.Split('\t');
            helyezes= int.Parse(vag[0]);
            nev= vag[1];
            fhely= vag[2];
            orszag= vag[3];
            hossz= int.Parse(vag[4]);
            ev= int.Parse(vag[5]);
        }

        
    }
}
