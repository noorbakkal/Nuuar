using System;
using System.Collections.Generic;

namespace Api.Database.Models
{
    public partial class AdComments
    {
        public int CommentId { get; set; }
        public int AdId { get; set; }
        public string CommentTitle { get; set; }
        public string CommentDescription { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? TermDate { get; set; }
        public bool? Active { get; set; }
    }
}
