using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Linq.Dynamic.Core;

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

        public static IQueryable<Game> Sort(this IQueryable<Game> games, string orderBy)
        {
            if (string.IsNullOrWhiteSpace(orderBy))
                return games.OrderBy(x => x.Name);

            var orderParams = orderBy.Trim().Split(',');
            var propertyInfos = typeof(Game).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var orderQueryBuilder = new StringBuilder();

            foreach(var param in orderParams)
            {
                if (string.IsNullOrWhiteSpace(param))
                    continue;

                var propertyFromQueryName = param.Split(" ")[0];
                var objectProperty = propertyInfos.FirstOrDefault(x =>
                    x.Name.Equals(propertyFromQueryName, StringComparison.InvariantCultureIgnoreCase));

                if (objectProperty == null)
                    continue;

                var direction = param.EndsWith(" desc") ? "descending" : "ascending";

                orderQueryBuilder.Append($"{objectProperty.Name.ToString()} {direction}, ");
            }

            var orderQuery = orderQueryBuilder.ToString().TrimEnd(',', ' ');

            if (string.IsNullOrWhiteSpace(orderQuery))
                return games.OrderBy(x => x.Name);

            return games.OrderBy(orderQuery);
        }
    }
}
