using AutoMapper;
using Superheroes.Entities;
using Superheroes.Models;

namespace Superheroes.Mappings
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            // REST API
            CreateMap<Superhero, SuperheroModel>();
            CreateMap<Powerstats, PowerstatsModel>();
            CreateMap<Appearance, AppearanceModel>();
            CreateMap<Biography, BiographyModel>();
            CreateMap<Work, WorkModel>();
            CreateMap<Connections, ConnectionsModel>();
            CreateMap<Images, ImagesModel>();

            // gRPC
            CreateMap<Superhero, Superheroes.Protos.Superhero>();
            CreateMap<Powerstats, Superheroes.Protos.Powerstats>();
            CreateMap<Appearance, Superheroes.Protos.Appearance>();
        }
    }
}
