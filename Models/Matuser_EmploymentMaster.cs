namespace VivahikSearchApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Matuser_EmploymentMaster
    {
        public int Matuser_EmploymentMasterID { get; set; }

        [StringLength(200)]
        public string Matuser_Employmentdetails { get; set; }
    }
}
