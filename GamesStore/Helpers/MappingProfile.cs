using AutoMapper;
using Entities.Models;
using Shared.DTO;

namespace GamesStore.Helpers
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Game, GamesDto>()
                .ForMember(x => x.Genre, b=> b.MapFrom(c=> c.Genre.Name))
                .ForMember(x => x.ConsoleDevice, b => b.MapFrom(d => d.ConsoleDevice.Name));
            CreateMap<ConsoleDevice, ConsoleDto>();
            CreateMap<Genre, GenreDto>();
            CreateMap<GameForCreateDto, Game>();
            CreateMap<GameForUpdateDto, Game>().ReverseMap();
            CreateMap<UserForRegistrationDto, AppUser>();
                
        }
    }
}
