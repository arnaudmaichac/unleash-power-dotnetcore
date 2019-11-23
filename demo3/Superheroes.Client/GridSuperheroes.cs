using Superheroes.Client.Interfaces;
using Superheroes.Client.Services;
using Superheroes.Client.ViewModels;
using System;
using System.Windows.Forms;

namespace Superheroes.Client
{
    public partial class GridSuperheroes : Form, IForm
    {
        private readonly NavigationService navigationService;
        private readonly SuperheroesService superheroesService;

        public GridSuperheroes(NavigationService navigationService, SuperheroesService superheroesService)
        {
            InitializeComponent();

            this.navigationService = navigationService;
            this.superheroesService = superheroesService;
        }

        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.gridControl1.DataSource = await superheroesService.GetSuperheroes();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.GetRow(gridView1.FocusedRowHandle) is SuperheroViewModel superheroViewModel)
            {
                navigationService.ShowModal<DetailSuperhero, int>(superheroViewModel.Id);
            }
        }
    }
}
