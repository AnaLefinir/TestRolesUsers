using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Test.CustomAttribute;

namespace Test.ViewModel
{
    public class RolViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "La Descripcion del Rol es requerida")]
        [Display(Name = "Descripción del Rol")]
        public string Description { get; set; }
        [Required(ErrorMessage = "El Valor es requerido")]
        [PotenciaDeDos(ErrorMessage = "El valor debe ser potencia de dos")]
        [Display(Name = "Valor del Rol")]
        public int Value { get; set; }
    }
}
