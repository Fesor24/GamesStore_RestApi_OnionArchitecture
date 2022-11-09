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

        public async Task<IEnumerable<Genre>> GetAllGenres(bool trackChanges) =>
            await GetAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToListAsync();
       
            

    }
}
