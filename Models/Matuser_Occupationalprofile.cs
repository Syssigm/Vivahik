namespace VivahikSearchApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Matuser_Occupationalprofile
    {
        [Key]
        public int MatUser_OccupationalID { get; set; }

        public int? Matuser_EducationalID { get; set; }

        public int? Matuser_EmploymentID { get; set; }

        [Required]
        [StringLength(20)]
        public string MatUser_ProfileIDGN { get; set; }
    }
}
