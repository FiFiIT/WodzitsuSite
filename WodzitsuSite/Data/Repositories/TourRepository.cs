using Microsoft.EntityFrameworkCore;
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

        public void DeleteTour(int Id)
        {
            var tour = GetTour(Id);

            if(tour != null)
            {
                context.Tours.Remove(tour);
                context.SaveChanges();
            }
            
        }

        public IEnumerable<Tour> GetAllTours()
        {
            return context.Tours.OrderBy(t => t.Name);
        }

        public IEnumerable<Tour> GetAllToursWithScores()
        {
            throw new NotImplementedException();
        }

        public Tour GetTour(int id)
        {
            return context.Tours.FirstOrDefault(t => t.Id == id);
        }

        public IEnumerable<TourScore> GetTourScores(int id)
        {
            return context.Scores.Where(s => s.TourID == id);
        }

        public void SaveTour(Tour tour)
        {
            context.Tours.Add(tour);
            context.SaveChanges();
        }

        public void ScoreTour(int tourId, decimal score, string userID)
        {
            if (context.Scores.Any(s => s.TourID == tourId && s.UserId == userID))
            {
                var ts = context.Scores.FirstOrDefault(s => s.TourID == tourId && s.UserId == userID);
                ts.Score = score;
                context.Scores.Update(ts);
            }
            else
            {
                var ts = new TourScore() { UserId = userID, TourID = tourId, Score = score };
                context.Scores.Add(ts);
            }

            context.SaveChanges();
        }

        public void UpdateTour(Tour editTour)
        {
            context.Tours.Update(editTour);
            context.SaveChanges();
        }
    }
}
