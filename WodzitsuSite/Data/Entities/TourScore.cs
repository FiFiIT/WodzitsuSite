using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WodzitsuSite.Data.Entities
{
    public class TourScore
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int TourID { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{F2}")]
        public decimal Score { get; set; }
    }
}
