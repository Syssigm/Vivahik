namespace VivahikSearchApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Matuser_Maritalstatus
    {
        public int MatUser_MaritalStatusID { get; set; }

        [StringLength(50)]
        public string Matuser_MaritalStatusdesc { get; set; }
    }
}
