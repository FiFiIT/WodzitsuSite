using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WodzitsuSite.Data.Entities
{
    public class Tour
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime TerminOd { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime TerminDo { get; set; }
        public string SamolotFirma { get; set; }
        [Required]
        public decimal SamolotCena { get; set; }
        public string Hotel { get; set; }
        [Required]
        public decimal HotelCena { get; set; }
        [Required]
        public string Organizator { get; set; }
        public string Zdjecie { get; set; }
        [Required]
        [MinLength(10)]
        public string Opis { get; set; }
    }
}
