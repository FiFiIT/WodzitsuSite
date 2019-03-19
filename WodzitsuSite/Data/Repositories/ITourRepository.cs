using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WodzitsuSite.Data.Entities;

namespace WodzitsuSite.Data.Repositories
{
    public interface ITourRepository
    {
        IEnumerable<Tour> GetAllTours();
    }
}
