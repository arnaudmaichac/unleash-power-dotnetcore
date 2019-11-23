using System.Collections.Generic;
using System.Threading.Tasks;
using Superheroes.Models;

namespace Superheroes.Interfaces
{
    public interface ISuperheroesService
    {
        IList<SuperheroModel> GetAll();
        SuperheroModel GetById(int id);
        IList<SuperheroModel> GetByName(string name, bool strict);
    }
}