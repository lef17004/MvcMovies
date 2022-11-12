using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
//using MvcMovie.Data;
using MvcMovieData;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Rating = "G",
                        Price = 7.99M,
                        Url = "https://flxt.tmsimg.com/assets/p11747_p_v8_as.jpg"
                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Rating = "PG",
                        Price = 8.99M,
                        Url = "https://upload.wikimedia.org/wikipedia/en/2/2f/Ghostbusters_%281984%29_theatrical_poster.png"
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Rating = "PG-13",
                        Price = 9.99M,
                        Url = "https://resizing.flixster.com/8nnRgW4_nBak9afhfsXUDN130_E=/ems.cHJkLWVtcy1hc3NldHMvbW92aWVzLzNjODk4YjM4LTBjNmUtNGMwMS04MWFmLWIyZWQ4OTIxNjkyMC53ZWJw"
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Rating = "R",
                        Price = 3.99M,
                        Url = "https://www.themoviedb.org/t/p/w500/4gI4KKmoi0d3yfsF71YU3S0I5t8.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}