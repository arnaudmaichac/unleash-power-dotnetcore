using System.Collections.Generic;
using System.Threading.Tasks;
using Superheroes.Entities;

namespace Superheroes.Interfaces
{
    public interface ISuperheroesRepository
    {
        IList<Superhero> GetAll();
        Superhero GetById(int id);
        IList<Superhero> GetByName(string name, bool strict);
        Task LoadAsync();
    }
}