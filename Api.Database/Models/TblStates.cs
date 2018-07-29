using System;
using System.Collections.Generic;

namespace Api.Database.Models
{
    public partial class TblStates
    {
        public TblStates()
        {
            TblCities = new HashSet<TblCities>();
        }

        public int StateId { get; set; }
        public string StateName { get; set; }
        public int CountryId { get; set; }

        public TblCountries Country { get; set; }
        public ICollection<TblCities> TblCities { get; set; }
    }
}
