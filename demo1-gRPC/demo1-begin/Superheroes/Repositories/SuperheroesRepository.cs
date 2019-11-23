using Newtonsoft.Json;
using Superheroes.Entities;
using Superheroes.Interfaces;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Superheroes.Repositories
{
    public class SuperheroesRepository : ISuperheroesRepository
    {
        private static IList<Superhero> _superheroes;

        public async Task LoadAsync()
        {
            var fileContent = await File.ReadAllTextAsync("Data/all.json");
            _superheroes = JsonConvert.DeserializeObject<IList<Superhero>>(fileContent);
        }

        public IList<Superhero> GetAll()
        {
            return _superheroes;
        }

        public Superhero GetById(int id)
        {
            return _superheroes.First(s => s.Id == id);
        }

        public IList<Superhero> GetByName(string name, bool strict)
        {
            if (strict)
            {
                return _superheroes.Where(s => s.Name.ToLower() == name.ToLower()).ToList();
            }

            return _superheroes.Where(s => s.Name.ToLower().Contains(name.ToLower())).ToList();
        }
    }
}