using System;
using System.Collections.Generic;

namespace Nuuar.Models
{
    public partial class Countries
    {
        public int Id { get; set; }
        public string SortName { get; set; }
        public string Name { get; set; }
        public int PhoneCode { get; set; }
    }
}
