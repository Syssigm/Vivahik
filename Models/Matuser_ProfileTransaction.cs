namespace VivahikSearchApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Matuser_ProfileTransaction
    {
        public int Matuser_ProfileTransactionID { get; set; }

        public int Matuser_SourceProfileID { get; set; }

        public int Matuser_SearchPartnerProfileID { get; set; }

        [Required]
        [StringLength(2)]
        public string Matuser_PartnerProfileStatus { get; set; }

        public DateTime Matuser_Createts { get; set; }

        public DateTime Matuser_Updatets { get; set; }
    }
}
