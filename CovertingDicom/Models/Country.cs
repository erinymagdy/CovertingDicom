using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class Country
    {
        public Country()
        {
            States = new HashSet<State>();
        }

        public int CountryId { get; set; }
        public string? CountryName { get; set; }
        public string? NationalityName { get; set; }

        public virtual ICollection<State> States { get; set; }
    }
}
