using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAplikacija
{
    internal class Klijent
    {
        public int? Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public string PunoIme => Prezime.StartsWith("(") ? Prezime : $"{Prezime}, {Ime}";
    }
}
