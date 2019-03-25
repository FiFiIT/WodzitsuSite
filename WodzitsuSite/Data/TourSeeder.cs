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

            if(context.Tours.Any())
            {
                return;
            }

            Czlopok czlopok = await userManager.FindByEmailAsync("filip.tyborowski@gmail.com");
            if (czlopok == null)
            {
                czlopok = new Czlopok()
                {
                    FirstName = "Filip",
                    LastName = "Tyborowski",
                    Email = "filip.tyborowski@gmail.com",
                    UserName = "Filip"
                };

                var restult = await userManager.CreateAsync(czlopok, "P@ssw0rd!");
                if (restult != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create new user in seeder");
                }
            }
            //KITEK
            Czlopok kitek = await userManager.FindByEmailAsync("marcin.kitek1@gmail.com");
            if (kitek == null)
            {
                kitek = new Czlopok()
                {
                    FirstName = "Marcin",
                    LastName = "Kitek",
                    Email = "marcin.kitek1@gmail.com",
                    UserName = "Kitek"
                };
                var kitekRestult = await userManager.CreateAsync(kitek, "Zakopane2019!");
                if (kitekRestult != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create new user in seeder");
                }
            }

            //Adrian
            Czlopok adrian = await userManager.FindByEmailAsync("Szturo@gmail.com");
            if (adrian == null)
            {
                adrian = new Czlopok()
                {
                    FirstName = "Adrian",
                    LastName = "Szturo",
                    Email = "marcin.kitek1@gmail.com",
                    UserName = "Adrian"
                };
                var adrianRestult = await userManager.CreateAsync(adrian, "Zakopane2019!");
                if (adrianRestult != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create new user in seeder");
                }
            }

            //Bialy
            Czlopok bialy = await userManager.FindByEmailAsync("Modlinski@gmail.com");
            if (bialy == null)
            {
                bialy = new Czlopok()
                {
                    FirstName = "Michał",
                    LastName = "Modlinski",
                    Email = "marcin.kitek1@gmail.com",
                    UserName = "Modlinski"
                };
                var bialyRestult = await userManager.CreateAsync(bialy, "Zakopane2019!");
                if (bialyRestult != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create new user in seeder");
                }
            }

            //Tobiasz
            Czlopok tobiasz = await userManager.FindByEmailAsync("tobiasz@gmail.com");
            if (tobiasz == null)
            {
                tobiasz = new Czlopok()
                {
                    FirstName = "Tobiasz",
                    LastName = "Pesla",
                    Email = "marcin.kitek1@gmail.com",
                    UserName = "Tobiasz"
                };
                var tobiaszRestult = await userManager.CreateAsync(tobiasz, "Zakopane2019!");
                if (tobiaszRestult != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create new user in seeder");
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
