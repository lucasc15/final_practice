using System;
using System.Collections.Generic;

namespace sail.Models
{
    public partial class Town
    {
        public string TownName { get; set; }
        public string ProvinceCode { get; set; }

        public virtual Province ProvinceCodeNavigation { get; set; }
    }
}
