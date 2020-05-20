namespace VivahikSearchApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Matuser_Login
    {
        public int MatUser_LoginID { get; set; }

        [Required]
        [StringLength(50)]
        public string Matuser_ProfileloginID { get; set; }

        [Required]
        [StringLength(40)]
        public string Matuser_ProfilePassword { get; set; }
    }
}
