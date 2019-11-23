using Superheroes.Client.Interfaces;
using Superheroes.Client.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Superheroes.Client
{
    public partial class DetailSuperhero : Form, IForm, IActivable<int>
    {
        private readonly SuperheroesService _superheroesService;
        private int _superheroId;

        public DetailSuperhero(SuperheroesService superheroesService)
        {
            InitializeComponent();

            _superheroesService = superheroesService;
        }

        public Task ActivateAsync(int parameter)
        {
            _superheroId = parameter;

            return Task.CompletedTask;
        }

        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var superheroViewModel = await _superheroesService.GetSuperheroByIdAsync(_superheroId);

            pictureBox1.LoadAsync(superheroViewModel.ImagesVM.Md);
            label1.Text = superheroViewModel.Name;
            lblGender.Text = superheroViewModel.AppearanceVM.Gender;
            lblEyeColor.Text = superheroViewModel.AppearanceVM.EyeColor;
            lblRace.Text = superheroViewModel.AppearanceVM.Race;
            lblHairColor.Text = superheroViewModel.AppearanceVM.HairColor;
        }
    }
}
