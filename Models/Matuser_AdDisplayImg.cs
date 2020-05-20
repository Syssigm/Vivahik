namespace VivahikSearchApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Matuser_AdDisplayImg
    {
        [Key]
        public int Matuser_AdDisplayID { get; set; }

        [StringLength(30)]
        public string Matuser_AdDisplayTitle { get; set; }

        [StringLength(50)]
        public string Matuser_DisplayPageName { get; set; }

        public int Matuser_AdBannerSizeID { get; set; }

        [StringLength(200)]
        public string Matuser_ImgUrl { get; set; }

        [StringLength(500)]
        public string Matuser_Desc { get; set; }

        public DateTime? Create_ts { get; set; }

        public DateTime? Update_ts { get; set; }

        [StringLength(100)]
        public string AdLocation { get; set; }

        public virtual MatAdBannerSize MatAdBannerSize { get; set; }
    }
}
