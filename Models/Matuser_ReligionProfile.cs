namespace VivahikSearchApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Matuser_ReligionProfile
    {
        [Key]
        public int MatUser_ProfileRelCastSubcastID { get; set; }

        [StringLength(30)]
        public string Matuser_SubcasteName { get; set; }

        [StringLength(30)]
        public string Matuser_GothraName { get; set; }

        public int? Matuser_ProfileCasteID { get; set; }

        [Required]
        [StringLength(20)]
        public string MatUser_ProfileIDGN { get; set; }

        public virtual Matuser_Caste Matuser_Caste { get; set; }
    }
}
