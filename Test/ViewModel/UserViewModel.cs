using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test.ViewModel
{
    public class UserViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El Legajo es requerido")]
        public string Legajo { get; set; }
        [Required(ErrorMessage = "El Nombre es requerido")]
        public string Name { get; set; }
    }
}
