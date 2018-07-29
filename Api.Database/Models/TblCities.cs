using System;
using System.Collections.Generic;

namespace Api.Database.Models
{
    public partial class TblCities
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int StateId { get; set; }

        public TblStates State { get; set; }
    }
}
