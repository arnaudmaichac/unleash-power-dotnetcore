using AutoMapper;
using Superheroes.Entities;
using Superheroes.Models;

namespace Superheroes.Mappings
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Superhero, SuperheroModel>();
            CreateMap<Powerstats, PowerstatsModel>();
            CreateMap<Appearance, AppearanceModel>();
            CreateMap<Biography, BiographyModel>();
            CreateMap<Work, WorkModel>();
            CreateMap<Connections, ConnectionsModel>();
            CreateMap<Images, ImagesModel>();
        }
    }
}
