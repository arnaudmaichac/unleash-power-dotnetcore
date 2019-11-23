using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes.Client.ViewModels
{
    public class SuperheroViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public AppearanceViewModel AppearanceVM { get; set; }

        public ImagesViewModel ImagesVM { get; set; }
    }

    public class ImagesViewModel
    {
        /// <summary>
        /// </summary>
        public string Xs { get; set; }

        /// <summary>
        /// </summary>
        public string Sm { get; set; }

        /// <summary>
        /// </summary>
        public string Md { get; set; }

        /// <summary>
        /// </summary>
        public string Lg { get; set; }
    }

    public class AppearanceViewModel
    {
        public string Gender { get; set; }

        public string Race { get; set; }

        public string EyeColor { get; set; }

        public string HairColor { get; set; }
    }
}
