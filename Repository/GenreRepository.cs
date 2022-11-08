using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class GenreRepository: GenericRepository<Genre>, IGenreRepository
    {
        public GenreRepository(AppDbContext context): base(context)
        {
                   
        }

        public IEnumerable<Genre> GetAllGenres(bool trackChanges) =>
            GetAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToList();
       
            

    }
}
