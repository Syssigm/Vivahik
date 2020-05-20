namespace VivahikSearchApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Matuser_Educationalprofile
    {
        [Key]
        public int MatUser_EducationalID { get; set; }

        public string Matuser_highestqualification { get; set; }
    }
}
