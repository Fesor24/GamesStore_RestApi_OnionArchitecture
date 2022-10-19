using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasData(
                new Genre
                {
                    Id = 1,
                    Name = "Simulation and Sports",
                    Description = "A game that simulates the practice of sports. Some games emphasize actually playing the sport, whilst others emphasize strategy and sport management"
                },

                 new Genre
                 {
                     Id = 2,
                     Name = "Racing",
                     Description = "A video game genre in which the player participates in a racing competition. They are distributed along a spectrum between more realistic racing simulations and more fantastical arcade-style racing games"
                 },

                  new Genre
                  {
                      Id = 3,
                      Name = "Sandbox",
                      Description = "In these games, players often have less concrete goals and narrative pathways to pursue. Instead of beating the boss and saving the princess, you may face a variety of tasks you can accomplish in a number of different ways. This draws players into more immersive experiences, encouraging experimantation with what may be unfamiliar mechanics"
                  },

                   new Genre
                   {
                       Id = 4,
                       Name = "Real-time strategy",
                       Description = "Players control different factions and compete against each other simultaneously in 'real-time' hence the term 'real-time strategy'"
                   },

                    new Genre
                    {
                        Id = 5,
                        Name = "Shooter(FPS and TPS)",
                        Description = "The shooter is a long standing genre that developed several early offshoots and branched out into two primary sub-genres: the first person(FPS) and third-person(TPS)."
                    },

                     new Genre
                     {
                         Id = 6,
                         Name = "Role-playing games",
                         Description = "The basic premise of the role playing game is simple and ubiquitious in numerous games: you create or take control of a character that you can then level up through experience points"
                     },

                      new Genre
                      {
                          Id = 7,
                          Name = "Action-adventure",
                          Description = "Among the earliest recognizable hybrid genres, action-adventure games have a deep focus on plot and combat through story involvement and tight gameplay mechanics"
                      },

                       new Genre
                       {
                           Id = 8,
                           Name = "Survival and Horror",
                           Description = "The core mechanics of a survival game centers on resource management, often incorporating crafting or salvage systems that you can use to help keep your character alive. Horror is an even broader category, arguably encompassing dozens of survival titles. Almost anything with zombies, a post-apocalyptic storyline, or loads of jump scares is considered horror"
                       }

                );
        }
    }
}
