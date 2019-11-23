using AutoMapper;
using Newtonsoft.Json;
using Superheroes.Entities;
using Superheroes.Interfaces;
using Superheroes.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Superheroes.Services
{
    public class SuperheroesService : ISuperheroesService
    {
        private readonly ISuperheroesRepository _superheroesRepository;
        private readonly IMapper _mapper;

        public SuperheroesService(ISuperheroesRepository superheroesRepository, IMapper mapper)
        {
            _superheroesRepository = superheroesRepository;
            _mapper = mapper;
        }

        public IList<SuperheroModel> GetAll()
        {
            return _mapper.Map<IList<SuperheroModel>>(_superheroesRepository.GetAll());
        }

        public SuperheroModel GetById(int id)
        {
            return _mapper.Map<SuperheroModel>(_superheroesRepository.GetById(id));
        }

        public IList<SuperheroModel> GetByName(string name, bool strict)
        {
            return _mapper.Map<IList<SuperheroModel>>(_superheroesRepository.GetByName(name, strict));
        }
    }
}
