namespace VivahikSearchApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Matuser_Astrologicalprofile
    {
        [Key]
        public int Matuser_ProfileAstrologicalID { get; set; }

        public int Matuser_ProfileRaasiID { get; set; }

        public int Matuser_ProfileStarID { get; set; }

        [StringLength(1)]
        public string Matuser_Kujadoshamflag { get; set; }

        [Required]
        [StringLength(20)]
        public string MatUser_ProfileIDGN { get; set; }

        public virtual Matuser_Raasi Matuser_Raasi { get; set; }

        public virtual Matuser_Star Matuser_Star { get; set; }
    }
}
