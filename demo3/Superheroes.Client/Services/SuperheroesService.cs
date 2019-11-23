using Microsoft.Rest;
using Superheroes.Client.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace Superheroes.Client.Services
{
    public class SuperheroesService
    {
        private readonly SuperheroesAPI _superheroesAPI;

        public SuperheroesService()
        {
            _superheroesAPI = new SuperheroesAPI(
                new Uri(ConfigurationManager.AppSettings["SuperheroesApiUrl"]),
                new AnonymousCredentials());
        }

        public async Task<IList<SuperheroViewModel>> GetSuperheroes()
        {
            var result = await _superheroesAPI.SuperheroesOperations.GetAllAsync();

            return result.Select(r => new SuperheroViewModel
            {
                Id = r.Id,
                Name = r.Name
            }).ToList();
        }

        public async Task<SuperheroViewModel> GetSuperheroByIdAsync(int id)
        {
            var result = await _superheroesAPI.SuperheroesOperations.GetByIdAsync(id);

            return new SuperheroViewModel
            {
                Id = result.Id,
                Name = result.Name,
                AppearanceVM = new AppearanceViewModel
                {
                    Gender = result.Appearance.Gender,
                    Race = result.Appearance.Race,
                    EyeColor = result.Appearance.EyeColor,
                    HairColor = result.Appearance.HairColor
                },
                ImagesVM = new ImagesViewModel
                {
                    Xs = result.Images.Xs,
                    Sm = result.Images.Sm,
                    Md = result.Images.Md,
                    Lg = result.Images.Lg
                }
            };
        }
    }

    public class AnonymousCredentials : ServiceClientCredentials
    {

    }
}
