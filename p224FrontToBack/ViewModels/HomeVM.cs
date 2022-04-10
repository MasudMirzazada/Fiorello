using p224FrontToBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace p224FrontToBack.ViewModels
{
    public class HomeVM
    {
        public List<Slider>Sliders   { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public Caption Caption { get; set; }
        public About About { get; set; }

    }
}
