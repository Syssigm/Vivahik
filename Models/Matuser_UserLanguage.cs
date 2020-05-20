namespace VivahikSearchApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Matuser_UserLanguage
    {
        [Key]
        public int Matuser_MotherTongueID { get; set; }

        [StringLength(30)]
        public string Matuser_MotherTongueLanguage { get; set; }

        [StringLength(1)]
        public string Langindicator { get; set; }
    }
}
