namespace VivahikSearchApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Matuser_Photo
    {
        public int Matuser_PhotoID { get; set; }

        [StringLength(50)]
        public string Matuser_Phototititle { get; set; }

        [StringLength(70)]
        public string Matuser_PhotoURL1 { get; set; }

        [StringLength(70)]
        public string Matuser_PhotoURL2 { get; set; }

        [StringLength(70)]
        public string Matuser_PhotoURL3 { get; set; }

        [StringLength(70)]
        public string Matuser_PhotoURL4 { get; set; }

        [StringLength(70)]
        public string Matuser_PhotoURL5 { get; set; }

        public DateTime? Create_ts { get; set; }

        public DateTime? Update_ts { get; set; }

        [Required]
        [StringLength(20)]
        public string MatUser_ProfileIDGN { get; set; }
    }
}
