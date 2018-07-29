using System;
using System.Collections.Generic;

namespace Api.Database.Models
{
    public partial class Ad
    {
        public Ad()
        {
            AdImages = new HashSet<AdImages>();
            AdMainImages = new HashSet<AdMainImages>();
        }

        public int AdId { get; set; }
        public string PenduUserName { get; set; }
        public int CategoryId { get; set; }
        public int? ImageId { get; set; }
        public int? AdminId { get; set; }
        public int? AdLocationId { get; set; }
        public string AdTitle { get; set; }
        public string AdDescription { get; set; }
        public string AdBusinessName { get; set; }
        public decimal? Rating { get; set; }
        public decimal? Price { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? TermDate { get; set; }
        public bool? Active { get; set; }
        public int? AdMainImage { get; set; }

        public ICollection<AdImages> AdImages { get; set; }
        public ICollection<AdMainImages> AdMainImages { get; set; }
    }
}
