using System;
using System.Collections.Generic;

namespace Nuuar.Models
{
    public partial class PenduUserClaims
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public PenduUsers User { get; set; }
    }
}
