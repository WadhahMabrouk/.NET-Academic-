using AutoMapper;
using MoviesProject.DTO;
using MoviesProject.Models;

namespace MoviesProject.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {
            CreateMap<Movie, MovieDetailsDTO>();
            CreateMap<MovieDTO, Movie>()
                .ForMember(src => src.Poster, opt => opt.Ignore());
        }
    }
}
