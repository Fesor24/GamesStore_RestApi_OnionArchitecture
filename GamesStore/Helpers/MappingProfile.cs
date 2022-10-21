using AutoMapper;
using Entities.Models;
using Shared.DTO;

namespace GamesStore.Helpers
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Game, GamesDto>();
        }
    }
}
