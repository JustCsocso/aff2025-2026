using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuggohid
{
    class fuggohid
    {
        public int helyezes;
        public string nev;
        public string fhely;
        public string orszag;
        public int hhossz;
        public int atadasev;
        public fuggohid(string sor)
        {
            string[]vag=sor.Split("\t");
            this.helyezes=int.Parse(vag[0]);
            this.nev=vag[1];
            this.fhely=vag[2];
            this.orszag=vag[3];
            this.hhossz=int.Parse(vag[4]);
            this.atadasev=int.Parse(vag[5]);
        }
    }
}
