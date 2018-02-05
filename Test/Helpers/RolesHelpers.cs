using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Entities;
using Test.ViewModel;

namespace Test.Helpers
{
    public class RolesHelpers
    {
        internal static RolViewModel MapRoles(Rol rolEntity)
        {
            RolViewModel rolViewModel = new RolViewModel
            {
                Id = rolEntity.Id,
                Description = rolEntity.Description,
                Value = rolEntity.Value
            };

            return rolViewModel;
        }
    }
}
