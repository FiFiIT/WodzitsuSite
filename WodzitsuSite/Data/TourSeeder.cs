using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WodzitsuSite.Data.Entities;

namespace WodzitsuSite.Data
{
    public class TourSeeder
    {
        private readonly TourContext context;
        private readonly UserManager<Czlopok> userManager;

        public TourSeeder(TourContext context, UserManager<Czlopok> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }

        public async Task SeedAsync()
        {
            context.Database.EnsureCreated();

            Czlopok czlopok = await userManager.FindByEmailAsync("filip.tyborowski@gmail.com");
            if(czlopok == null)
            {
                czlopok = new Czlopok()
                {
                    FirstName = "Filip",
                    LastName = "Tyborowski",
                    Email = "filip.tyborowski@gmail.com",
                    UserName = "Filip"
                };

                var restult = await userManager.CreateAsync(czlopok, "P@ssw0rd!");
                if(restult != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create new user in seeder");
                }
            }

            Czlopok czlopok2 = await userManager.FindByEmailAsync("marcin.kitek1@gmail.com");
            if (czlopok2 == null)
            {
                czlopok2 = new Czlopok()
                {
                    FirstName = "Marcin",
                    LastName = "Kitek",
                    Email = "marcin.kitek1@gmail.com",
                    UserName = "Kitek"
                };

                try
                {
                    var restult = await userManager.CreateAsync(czlopok2, "Zakopane2019!");
                    if (restult != IdentityResult.Success)
                    {
                        throw new InvalidOperationException("Could not create new user in seeder");
                    }
                }
                catch (Exception ex)
                {

                    throw;
                }
                
            }

            if (!context.Tours.Any())
            {
                context.Tours.AddRange(
                    new Tour()
                    {
                        Hotel = "Hotel W maladze",
                        HotelCena = 100,
                        Name = "Wycieczka do Malagi",
                        Opis = "Bedzie zajebiscie polecam",
                        Organizator = "Ewa",
                        SamolotCena = 500,
                        SamolotFirma = "Ryanair",
                        TerminDo = new DateTime(2019, 9, 6),
                        TerminOd = new DateTime(2019, 9, 1),
                        Zdjecie = "opcja1.png"
                    },
                    new Tour()
                    {
                        Hotel = "U Kitka",
                        HotelCena = 300,
                        Name = "Zakopane",
                        Opis = "jedziemy odwiedzic nowe miejsce Kitusia",
                        Organizator = "Filip",
                        SamolotCena = 0,
                        SamolotFirma = "Punto",
                        TerminDo = new DateTime(2019, 9, 21),
                        TerminOd = new DateTime(2019, 9, 23),
                        Zdjecie = "richbitch.png"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
