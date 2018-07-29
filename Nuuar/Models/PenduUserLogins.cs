using System;
using System.Collections.Generic;

namespace Nuuar.Models
{
    public partial class PenduUserLogins
    {
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public string UserId { get; set; }

        public PenduUsers User { get; set; }
    }
}
