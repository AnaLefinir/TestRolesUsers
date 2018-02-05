using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Legajo { get; set; }
        public string Name { get; set; }

        public virtual ICollection<UserRol> UserRol { get; set; }
    }
}
