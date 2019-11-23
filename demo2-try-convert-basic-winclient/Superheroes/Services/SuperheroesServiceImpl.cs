using AutoMapper;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Superheroes.Interfaces;
using Superheroes.Protos;
using System.Threading.Tasks;

namespace Superheroes.Services
{
    public class SuperheroesServiceImpl : Protos.Superheroes.SuperheroesBase
    {
        private readonly ISuperheroesRepository _superheroesRepository;
        private readonly IMapper _mapper;

        public SuperheroesServiceImpl(ISuperheroesRepository superheroesRepository, IMapper mapper)
        {
            _superheroesRepository = superheroesRepository;
            _mapper = mapper;
        }

        public override Task<GetAllResponse> GetAll(Empty request, ServerCallContext context)
        {
            return base.GetAll(request, context);
        }

        public override Task<GetByIdResponse> GetById(GetByIdRequest request, ServerCallContext context)
        {
            var superhero = _superheroesRepository.GetById(request.Id);

            return Task.FromResult(new GetByIdResponse
            {
                Superhero = _mapper.Map<Superhero>(superhero)
            });
        }

        public override Task<GetByNameResponse> GetByName(GetByNameRequest request, ServerCallContext context)
        {
            return base.GetByName(request, context);
        }
    }
}
