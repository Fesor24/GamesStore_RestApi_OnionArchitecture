using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Extensions
{
    public static class GameRepositoryExtension
    {
        public static IQueryable<Game> Search(this IQueryable<Game> games, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return games;

            var lowerSearchTerm = searchTerm.Trim().ToLower();

            return games.Where(x => x.Name.Trim().ToLower().Contains(lowerSearchTerm));
        }
    }
}
