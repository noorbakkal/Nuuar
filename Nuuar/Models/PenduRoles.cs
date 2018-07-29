using System;
using System.Collections.Generic;

namespace Nuuar.Models
{
    public partial class PenduRoles
    {
        public PenduRoles()
        {
            PenduUserRoles = new HashSet<PenduUserRoles>();
        }

        public string Id { get; set; }
        public string Name { get; set; }

        public ICollection<PenduUserRoles> PenduUserRoles { get; set; }
    }
}
