using System;
using System.Collections.Generic;

namespace Api.Database.Models
{
    public partial class TblCountries
    {
        public TblCountries()
        {
            TblStates = new HashSet<TblStates>();
        }

        public int CountryId { get; set; }
        public string SortName { get; set; }
        public string Name { get; set; }
        public int PhoneCode { get; set; }

        public ICollection<TblStates> TblStates { get; set; }
    }
}
