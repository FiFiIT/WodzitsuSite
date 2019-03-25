using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WodzitsuSite.Data.Entities;

namespace WodzitsuSite.ViewModels
{
    public class ScoreViewModel
    {
        public Tour tour { get; set; }
        public IList<TourScore> scores { get; set; }

        public decimal ScoreTotal
        {
            get
            {
                if (!scores.Any())
                {
                    return 0;
                }
                else
                {
                    return scores.Sum(s => s.Score);
                }
            }
        }
        public decimal ScoreAvg
        {
            get
            {
                if (!scores.Any())
                {
                    return 0;
                }
                else
                {
                    return scores.Average(s => s.Score);
                }
                
            }
        }
    }
}
