using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LoveSlipper.Data;
using System;
using System.Linq;

namespace LoveSlipper.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LoveSlipperContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<LoveSlipperContext>>()))
            {
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Slipper
                    {
                        Name = "LvX2",
                        ReleaseDate = DateTime.Parse("2022-04-11"),
                        Material = "leather",
                        Color = "Brown",
                        Category = "Male",
                        Price = 250,

                        Rating = 4
                    },
                     new Slipper
                     {
                         Name = "Flop",
                         ReleaseDate = DateTime.Parse("2019-03-22"),
                         Material = "Foam",
                         Color = "White",
                         Category = "female",
                         Price = 170,

                         Rating = 3
                     },
                      new Slipper
                      {
                          Name = "Champ",
                          ReleaseDate = DateTime.Parse("2023-01-05"),
                          Material = "cotton",
                          Color = "blue",
                          Category = "kids",
                          Price = 120,

                          Rating = 5
                      },
                       new Slipper
                       {
                           Name = "Bird",
                           ReleaseDate = DateTime.Parse("2018-04-23"),
                           Material = "suede",
                           Color = "Black",
                           Category = "Female",
                           Price = 240,

                           Rating = 3
                       },
                        new Slipper
                        {
                            Name = "BirdRefix",
                            ReleaseDate = DateTime.Parse("2021-05-25"),
                            Material = "Polar fleece X Suede",
                            Color = "black and Brown",
                            Category = "Female",
                            Price = 320,

                            Rating = 4
                        },
                         new Slipper
                         {
                             Name = "GRange",
                             ReleaseDate = DateTime.Parse("2015-06-25"),
                             Material = "Felt",
                             Color = "purple",
                             Category = "kids",
                             Price = 110,

                             Rating = 4
                         },
                          new Slipper
                          {
                              Name = "Flopx2",
                              ReleaseDate = DateTime.Parse("2022-09-22"),
                              Material = "terryCloth",
                              Color = "red",
                              Category = "Female",
                              Price = 330,

                              Rating = 3
                          },
                           new Slipper
                           {
                               Name = "FireX0",
                               ReleaseDate = DateTime.Parse("2023-10-11"),
                               Material = "Leather",
                               Color = "Brown",
                               Category = "Male",
                               Price = 450,

                               Rating = 4
                           },
                            new Slipper
                            {
                                Name = "Einstein",
                                ReleaseDate = DateTime.Parse("1999-05-21"),
                                Material = "Leather",
                                Color = "Navy-blue",
                                Category = "Male",
                                Price = 150,

                                Rating = 4
                            },
                             new Slipper
                             {
                                 Name = "Ye!slide",
                                 ReleaseDate = DateTime.Parse("2023-02-11"),
                                 Material = "Soft-Rubber",
                                 Color = "black",
                                 Category = "male",
                                 Price = 180,

                                 Rating = 4
                             }

); context.SaveChanges();


            }
        }
    }
}      
        
