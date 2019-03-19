using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WodzitsuSite.Data.Entities;

namespace WodzitsuSite.Data.Repositories
{
    public class TourRepository : ITourRepository
    {
        private readonly TourContext context;

        public TourRepository(TourContext context)
        {
            this.context = context;
        }

        public IEnumerable<Tour> GetAllTours()
        {
            return context.Tours.OrderBy(t => t.Name);
        }
    }
}
