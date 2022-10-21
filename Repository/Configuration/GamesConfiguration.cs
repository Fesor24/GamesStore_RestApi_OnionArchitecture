using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class GamesConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasData(
                new Game
                {
                    Id = 1,
                    Name = "Resident Evil",
                    Price = 130.50m,
                    Description = "A Japanese horror game series and a media franchise created by Capcom. It consists of survival horro, third-person shooter ad first-person shooter games, with players typically surviving in environments filled with zombies and other creatures",
                    ImageUrl = "https://images.unsplash.com/photo-1575844261401-d69721eb5044?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MXx8cmVzaWRlbnQlMjBldmlsfGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60",
                    ConsoleId = 2,
                    GenreId = 8,

                },

                 new Game
                 {
                     Id = 2,
                     Name = "Star Wars",
                     Price = 100.75m,
                     Description = "From a galaxy far, far away comes action and adventure with the heroes and villians of Star Wars. Master the art of starfighter combat in the authentic piloting experience. Master your hero's journey and play through massive battles across iconic locations in all three cinematic eras",
                     ImageUrl = "https://images.unsplash.com/flagged/photo-1589829482673-03413c918c48?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8OHx8c3RhciUyMHdhcnN8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60",
                     ConsoleId = 4,
                     GenreId = 7,

                 },

                  new Game
                  {
                      Id = 3,
                      Name = "NBA 2K",
                      Price = 130.50m,
                      Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.",
                      ImageUrl = "https://images.unsplash.com/photo-1563506644863-444710df1e03?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTN8fG5iYXxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60",
                      ConsoleId = 2,
                      GenreId = 8,

                  },

                   new Game
                   {
                       Id = 27,
                       Name = "The Witcher 3",
                       Price = 90.50m,
                       Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.",
                       ImageUrl = "https://images.unsplash.com/photo-1622643048696-883eafe4d8dc?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MXx8d2l0Y2hlcnxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60",
                       ConsoleId = 5,
                       GenreId = 6,

                   },

                    new Game
                    {
                        Id = 4,
                        Name = "Call of Duty",
                        Price = 150.50m,
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.",
                        ImageUrl = "https://images.unsplash.com/photo-1602901248692-06c8935adac0?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NHx8Y2FsbCUyMG9mJTIwZHV0eXxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60",
                        ConsoleId = 1,
                        GenreId = 5,

                    },

                     new Game
                     {
                         Id = 5,
                         Name = "Warcraft",
                         Price = 80.20m,
                         Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.",
                         ImageUrl = "https://images.unsplash.com/photo-1612404819070-77c6da472e68?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Nnx8d2FyY3JhZnR8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60",
                         ConsoleId = 4,
                         GenreId = 4,

                     },

                      new Game
                      {
                          Id = 6,
                          Name = "Minecraft",
                          Price = 200.50m,
                          Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.",
                          ImageUrl = "https://images.unsplash.com/photo-1640079421264-61f50d89a736?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NHx8bWluZWNyYWZ0fGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60",
                          ConsoleId = 2,
                          GenreId = 3,

                      },

                       new Game
                       {
                           Id = 7,
                           Name = "Grand Theft Auto",
                           Price = 120.55m,
                           Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.",
                           ImageUrl = "https://images.unsplash.com/photo-1624085568108-36410cfe4d24?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTB8fGdyYW5kJTIwdGhlZnQlMjBhdXRvfGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60",
                           ConsoleId = 2,
                           GenreId = 3,

                       },

                        new Game
                        {
                            Id = 8,
                            Name = "The Sims",
                            Price = 90.50m,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.",
                            ImageUrl = "https://images.unsplash.com/photo-1496252223350-db9ad24b108c?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8dGhlJTIwc2ltc3xlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60",
                            ConsoleId = 1,
                            GenreId = 3,

                        },

                         new Game
                         {
                             Id = 9,
                             Name = "Age of Empires",
                             Price = 130.75m,
                             Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.",
                             ImageUrl = "https://images.unsplash.com/photo-1630713079609-4356d4106410?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8N3x8d2FyY3JhZnR8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60",
                             ConsoleId = 5,
                             GenreId = 4,

                         },

                          new Game
                          {
                              Id = 10,
                              Name = "Command & Conquer",
                              Price = 100.25m,
                              Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.",
                              ImageUrl = "https://images.unsplash.com/photo-1638451490307-80b960906103?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8OXx8d2FyY3JhZnR8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60",
                              ConsoleId = 3,
                              GenreId = 4,

                          },

                           new Game
                           {
                               Id = 11,
                               Name = "DOOM",
                               Price = 120.50m,
                               Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.",
                               ImageUrl = "https://images.unsplash.com/photo-1598776454302-94acd47baaa8?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MXx8c2hvb3RpbmclMjBnYW1lfGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60",
                               ConsoleId = 5,
                               GenreId = 5,

                           },

                            new Game
                            {
                                Id = 12,
                                Name = "Half-life",
                                Price = 120.30m,
                                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.",
                                ImageUrl = "https://images.unsplash.com/photo-1620231150904-a86b9802656a?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8M3x8Y2FsbCUyMG9mJTIwZHV0eXxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60",
                                ConsoleId = 3,
                                GenreId = 5,

                            },

                             new Game
                             {
                                 Id = 13,
                                 Name = "Gears of War",
                                 Price = 90.50m,
                                 Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.",
                                 ImageUrl = "https://images.unsplash.com/photo-1621364525332-f9c381f3bfe8?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NXx8Y2FsbCUyMG9mJTIwZHV0eXxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60",
                                 ConsoleId = 1,
                                 GenreId = 5,

                             },

                              new Game
                              {
                                  Id = 14,
                                  Name = "The Division",
                                  Price = 60.50m,
                                  Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.",
                                  ImageUrl = "https://images.unsplash.com/photo-1621886289899-6e78c8f379b0?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8N3x8Y2FsbCUyMG9mJTIwZHV0eXxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60",
                                  ConsoleId = 3,
                                  GenreId = 5,

                              },

                               new Game
                               {
                                   Id = 15,
                                   Name = "Halo",
                                   Price = 170.40m,
                                   Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.",
                                   ImageUrl = "https://images.unsplash.com/photo-1612212909979-5f9128008f87?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTl8fGNhbGwlMjBvZiUyMGR1dHl8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60",
                                   ConsoleId = 2,
                                   GenreId = 5,

                               },

                                new Game
                                {
                                    Id = 16,
                                    Name = "Skyrim",
                                    Price = 220.50m,
                                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.",
                                    ImageUrl = "https://images.unsplash.com/photo-1521252879211-999820594c75?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTZ8fHJvbGUlMjBwbGF5aW5nJTIwZ2FtZXN8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60",
                                    ConsoleId = 2,
                                    GenreId = 6,

                                },

                                 new Game
                                 {
                                     Id = 17,
                                     Name = "Fallout 4",
                                     Price = 115.50m,
                                     Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.",
                                     ImageUrl = "https://images.unsplash.com/photo-1484608577325-c7540cc6794d?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTJ8fGZhbGxvdXR8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60",
                                     ConsoleId = 1,
                                     GenreId = 6,

                                 },

                                  new Game
                                  {
                                      Id = 18,
                                      Name = "Forza Motorsport",
                                      Price = 300.50m,
                                      Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.",
                                      ImageUrl = "https://images.unsplash.com/photo-1624432105547-898636528f55?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTR8fGdyYW5kJTIwdGhlZnQlMjBhdXRvfGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60",
                                      ConsoleId = 1,
                                      GenreId = 1,

                                  },

                                   new Game
                                   {
                                       Id = 19,
                                       Name = "FIFA 2023",
                                       Price = 320.50m,
                                       Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.",
                                       ImageUrl = "https://images.unsplash.com/photo-1598121876853-82437626c783?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8N3x8bWVzc2l8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60",
                                       ConsoleId = 4,
                                       GenreId = 1,

                                   },

                                    new Game
                                    {
                                        Id = 20,
                                        Name = "FIFA 2022",
                                        Price = 280.50m,
                                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.",
                                        ImageUrl = "https://images.unsplash.com/photo-1522778034537-20a2486be803?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NHx8cm9uYWxkb3xlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60",
                                        ConsoleId = 5,
                                        GenreId = 1,

                                    },

                                     new Game
                                     {
                                         Id = 21,
                                         Name = "Assassin's Creed",
                                         Price = 120.50m,
                                         Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.",
                                         ImageUrl = "https://images.unsplash.com/photo-1652718425243-8fb1512f4026?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NHx8YXNzYXNpbiUyMGNyZWVkfGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60",
                                         ConsoleId = 2,
                                         GenreId = 7,

                                     },

                                      new Game
                                      {
                                          Id = 22,
                                          Name = "Monkey Island",
                                          Price = 220.50m,
                                          Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.",
                                          ImageUrl = "https://plus.unsplash.com/premium_photo-1661901234139-d833950e05e0?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTN8fGd1bnN8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60",
                                          ConsoleId = 2,
                                          GenreId = 7,

                                      },

                                       new Game
                                       {
                                           Id = 23,
                                           Name = "Watch Dogs",
                                           Price = 270.50m,
                                           Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.",
                                           ImageUrl = "https://images.unsplash.com/photo-1602901248692-06c8935adac0?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTZ8fGd1bnN8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60",
                                           ConsoleId = 4,
                                           GenreId = 7,

                                       },

                                        new Game
                                        {
                                            Id = 24,
                                            Name = "Titanfall",
                                            Price = 90.50m,
                                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.",
                                            ImageUrl = "https://images.unsplash.com/photo-1519669556878-63bdad8a1a49?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NHx8Z2FtZXN8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60",
                                            ConsoleId = 4,
                                            GenreId = 7,

                                        },

                                        new Game
                                        {
                                            Id = 25,
                                            Name = "The Long Dark",
                                            Price = 200.50m,
                                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.",
                                            ImageUrl = "https://images.unsplash.com/photo-1543844481-52e5d6b93760?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Nnx8Z29kJTIwb2YlMjB3YXJ8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60",
                                            ConsoleId = 1,
                                            GenreId = 8,

                                        },

                                        new Game
                                        {
                                            Id = 26,
                                            Name = "Don't Starve",
                                            Price = 190.50m,
                                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit sed do eiusmud tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillium dolore eu fugiat nulla pariatur.",
                                            ImageUrl = "https://images.unsplash.com/photo-1608744221958-a842da518d01?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8Z29kJTIwb2YlMjB3YXJ8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60",
                                            ConsoleId = 4,
                                            GenreId = 7,

                                        }

                );
        }
    }
}
