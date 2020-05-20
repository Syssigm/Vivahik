namespace VivahikSearchApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Matuser_Plan
    {
        public int Matuser_PlanID { get; set; }

        [StringLength(30)]
        public string Matuser_Planname { get; set; }

        public int? Matuser_Planperioddays { get; set; }

        public double? Matuser_PriceinUSD { get; set; }

        public double? Matuser_PriceinINR { get; set; }

        public DateTime? Matuser_Planstartdate { get; set; }

        public DateTime? Matuser_Planenddate { get; set; }

        [StringLength(1)]
        public string Matuser_activeflag { get; set; }

        public DateTime? Create_ts { get; set; }

        public DateTime? Update_ts { get; set; }

        [Required]
        [StringLength(20)]
        public string MatUser_ProfileIDGN { get; set; }
    }
}
