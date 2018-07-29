using System;
using System.Collections.Generic;

namespace Api.Database.Models
{
    public partial class AdMainImages
    {
        public int MainImageId { get; set; }
        public int AdId { get; set; }
        public string UrlReference { get; set; }
        public string MainImageTitle { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? TermDate { get; set; }
        public bool? Active { get; set; }

        public Ad Ad { get; set; }
    }
}
