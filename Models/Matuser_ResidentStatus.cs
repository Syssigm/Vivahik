namespace VivahikSearchApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Matuser_ResidentStatus
    {
        public int Matuser_ResidentstatusID { get; set; }

        [Required]
        [StringLength(30)]
        public string Matuser_Residentstatusdesc { get; set; }
    }
}
