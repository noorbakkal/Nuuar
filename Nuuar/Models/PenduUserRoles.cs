using System;
using System.Collections.Generic;

namespace Nuuar.Models
{
    public partial class PenduUserRoles
    {
        public string UserId { get; set; }
        public string RoleId { get; set; }

        public PenduRoles Role { get; set; }
    }
}
