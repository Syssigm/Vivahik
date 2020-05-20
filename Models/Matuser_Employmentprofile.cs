namespace VivahikSearchApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Matuser_Employmentprofile
    {
        [Key]
        public int Matuser_EmploymentID { get; set; }

        [StringLength(200)]
        public string Matuser_Employmentdetails { get; set; }

        public int? Matuser_SalaryinLakhrupees { get; set; }

        [StringLength(200)]
        public string EmployerName { get; set; }

        [Required]
        [StringLength(20)]
        public string MatUser_ProfileIDGN { get; set; }
    }
}
