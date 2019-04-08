using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WodzitsuSite.Data.Entities
{
    public class Tour : IValidatableObject
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime TerminOd { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
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
        [DataType(DataType.MultilineText)]
        public string Opis { get; set; }

        public List<TourScore> Scores { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> res = new List<ValidationResult>();
            if (TerminDo < TerminOd)
            {
                ValidationResult mss = new ValidationResult("'Termin do' jest ustawiany przed 'Temrmin od'");
                res.Add(mss);
            }
            return res;
        }
    }
}
