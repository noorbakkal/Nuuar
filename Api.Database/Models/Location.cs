using System;
using System.Collections.Generic;

namespace Api.Database.Models
{
    public partial class Location
    {
        public int LocationId { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public int LanguageId { get; set; }
    }
}
