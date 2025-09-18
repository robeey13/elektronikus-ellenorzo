using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elektronikus_ellenorzo
{
    public class Tanulo
    {
        public string Nev { get; set; }
        public string SzuletesiHely { get; set; }
        public DateTime SzuletesiIdo { get; set; }
        public string AnyjaNeve { get; set; }
        public string Lakcim { get; set; }
        public DateTime BeiratkozasIdopontja { get; set; }
        public string Szak { get; set; }
        public string Osztaly { get; set; }
        public bool Kollegista { get; set; }
        public string KollegiumNev { get; set; }
    }
}
