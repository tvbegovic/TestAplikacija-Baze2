using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAplikacija
{
    internal class Narudzba
    {
        public int Id { get; set; }
        public DateTime? DatumNarudzbe { get; set; }        
        public decimal? Ukupno { get; set; }
    }
}
