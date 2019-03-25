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
        Tour GetTour(int id);
        void SaveTour(Tour tour);
        void UpdateTour(Tour editTour);
        void DeleteTour(int t);
        IEnumerable<TourScore> GetTourScores(int id);
        void ScoreTour(int tourId, decimal score, string v);
    }
}
