using FirstMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FirstMVCContext(
                serviceProvider.GetRequiredService<DbContextOptions<FirstMVCContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                     new Movie
                     {
                         Title = "17 Miracles",
                         ReleaseDate = DateTime.Parse("2011-1-11"),
                         Genre = "Romantic Comedy",
                         Price = 7.99M
                     },

                     new Movie
                     {
                         Title = "The Other Side of Heaven",
                         ReleaseDate = DateTime.Parse("2001-3-13"),
                         Genre = "Comedy",
                         Price = 8.99M
                     },

                     new Movie
                     {
                         Title = "The R.M.",
                         ReleaseDate = DateTime.Parse("2003-2-23"),
                         Genre = "Comedy",
                         Price = 9.99M
                     },

                   new Movie
                   {
                       Title = "The Singles Ward",
                       ReleaseDate = DateTime.Parse("2002-4-15"),
                       Genre = "Comedy",
                       Price = 3.99M
                   }
                );
                context.SaveChanges();
            }
        }
    }
}