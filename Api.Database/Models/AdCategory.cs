using System;
using System.Collections.Generic;

namespace Api.Database.Models
{
    public partial class AdCategory
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public string CategoryImageReference { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? TermDate { get; set; }
        public bool? Active { get; set; }
    }
}
