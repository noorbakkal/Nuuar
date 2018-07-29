using System;
using System.Collections.Generic;

namespace Nuuar.Models
{
    public partial class PenduUserInfo
    {
        public int PenduUserId { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? TermDate { get; set; }
        public bool? Active { get; set; }
    }
}
