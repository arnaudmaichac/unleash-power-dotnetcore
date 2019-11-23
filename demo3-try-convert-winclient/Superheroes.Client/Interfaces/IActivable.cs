using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes.Client.Interfaces
{
    public interface IActivable<T>
    {
        Task ActivateAsync(T parameter);
    }
}
