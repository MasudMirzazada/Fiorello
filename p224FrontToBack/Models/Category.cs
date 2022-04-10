using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace p224FrontToBack.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Teleb Olunur"),MaxLength(50,ErrorMessage="50den az olsun")]
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Product>Products { get; set; }
    }
}
