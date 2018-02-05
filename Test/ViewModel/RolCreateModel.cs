using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Test.CustomAttribute;

namespace Test.ViewModel
{
    public class RolCreateModel
    {
        [Required(ErrorMessage = "La Descripcion del Rol es requerida")]
        public string Description { get; set; }
        [Required(ErrorMessage = "El Valor es requerido")]
        [PotenciaDeDos(ErrorMessage = "El valor debe ser potencia de dos")]
        public int Value { get; set; }
    }
}
