namespace VivahikSearchApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Matuser_Profilefor
    {
        public int MatUser_ProfileForID { get; set; }

        [Required]
        [StringLength(40)]
        public string ProfileforName { get; set; }
    }
}
