namespace VivahikSearchApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Matuser_SalaryRange
    {
        [Key]
        public int Matuser_RangeID { get; set; }

        public int? Matuser_SalaryLowerrangeinlakhs { get; set; }

        public int? Matuser_SalaryUpperrangeinlakhs { get; set; }
    }
}
