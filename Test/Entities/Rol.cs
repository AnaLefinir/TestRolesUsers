using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Test.CustomAttribute;

namespace Test.Entities
{
    public class Rol
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Value { get; set; }

        public virtual ICollection<UserRol> UserRol { get; set; }
    }
}
