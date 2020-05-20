namespace VivahikSearchApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Matuser_Cntrycode
    {
        [Key]
        public int CntID { get; set; }

        public int? CountryID { get; set; }

        public int? CountryCode { get; set; }

        public virtual Matuser_Country Matuser_Country { get; set; }
    }
}
