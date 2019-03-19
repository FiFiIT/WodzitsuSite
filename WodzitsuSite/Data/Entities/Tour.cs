using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WodzitsuSite.Data.Entities
{
    public class Tour
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime TerminOd { get; set; }
        public DateTime TerminDo { get; set; }
        public string SamolotFirma { get; set; }
        public decimal SamolotCena { get; set; }
        public string Hotel { get; set; }
        public decimal HotelCena { get; set; }
        public string Organizator { get; set; }
        public string Zdjecie { get; set; }
        public string Opis { get; set; }
    }
}
