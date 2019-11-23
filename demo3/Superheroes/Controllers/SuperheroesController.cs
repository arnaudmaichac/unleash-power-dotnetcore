using Microsoft.AspNetCore.Mvc;
using Superheroes.Interfaces;
using Superheroes.Models;
using System.Collections.Generic;

namespace Superheroes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperheroesController : ControllerBase
    {
        private readonly ISuperheroesService superheroesService;

        public SuperheroesController(ISuperheroesService superheroesService)
        {
            this.superheroesService = superheroesService;
        }

        [HttpGet]
        public IList<SuperheroModel> GetAll()
        {
            return superheroesService.GetAll();
        }

        [HttpGet("{id:int}")]
        public SuperheroModel GetById(int id)
        {
            return superheroesService.GetById(id);
        }

        [HttpGet("search/{name}")]
        public IList<SuperheroModel> GetByName(string name, bool strict)
        {
            return superheroesService.GetByName(name, strict);
        }

    }
}