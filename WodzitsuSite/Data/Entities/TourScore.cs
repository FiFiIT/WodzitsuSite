using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WodzitsuSite.Data.Entities
{
    public class TourScore
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int TourID { get; set; }
        public decimal Score { get; set; }
    }
}
