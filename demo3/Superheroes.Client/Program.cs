using Superheroes.Client.Interfaces;
using Superheroes.Client.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace Superheroes.Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildContainer();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<GridSuperheroes>());
        }

        private static IUnityContainer BuildContainer()
        {
            var currentContainer = new UnityContainer();

            var forms = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.IsClass && !t.IsAbstract && t.GetInterfaces().Contains(typeof(IForm)));

            currentContainer.RegisterType<NavigationService>();
            currentContainer.RegisterType<SuperheroesService>();

            foreach (var form in forms)
            {
                currentContainer.RegisterType(typeof(IForm), form.GetType());
            }

            return currentContainer;
        }
    }
}
