using Superheroes.Client.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace Superheroes.Client.Services
{
    public class NavigationService
    {
        private readonly IUnityContainer container;

        public NavigationService(IUnityContainer container)
        {
            this.container = container;
        }

        public DialogResult ShowModal<TForm, TParam>(TParam parameter = default) where TForm : Form
        {
            using (var form = this.GetForm<TForm, TParam>(parameter))
            {
                return form.ShowDialog();
            }
        }

        private Form GetForm<TForm, TParam>(TParam parameter = default) where TForm : Form
        {
            var form = this.container.Resolve<TForm>();
            if (form is IActivable<TParam> activableForm)
            {
                activableForm.ActivateAsync(parameter);
            }

            return form;
        }
    }
}
