namespace VivahikSearchApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Matuser_BackgroundPersonalityInterests
    {
        [Key]
        public int Matuser_BgPerIntID { get; set; }

        public int Matuser_ProfileID { get; set; }

        [StringLength(1)]
        public string Matuser_BgAffluentflg { get; set; }

        [StringLength(1)]
        public string Matuser_BgEnjoysmusicflg { get; set; }

        [StringLength(1)]
        public string Matuser_BgWarmFriendlyflg { get; set; }

        [StringLength(1)]
        public string Matuser_BgCheerfulflg { get; set; }

        [StringLength(1)]
        public string Matuser_BgLikesphotographyflg { get; set; }

        [StringLength(1)]
        public string Matuser_BgEnjoysfoodflg { get; set; }

        [StringLength(1)]
        public string Matuser_BgWelleducatedflg { get; set; }

        [StringLength(1)]
        public string Matuser_BgSpirituallyinclinedflg { get; set; }

        [StringLength(1)]
        public string Matuser_BgAttractiveflg { get; set; }

        [StringLength(1)]
        public string Matuser_BgLovingflg { get; set; }

        [StringLength(1)]
        public string Matuser_BgLikesartflg { get; set; }

        [StringLength(1)]
        public string Matuser_BgLikesnatureflg { get; set; }

        [StringLength(1)]
        public string Matuser_BgFamilyorientedflg { get; set; }

        [StringLength(1)]
        public string Matuser_BgHealthconsciousflg { get; set; }

        [StringLength(1)]
        public string Matuser_BgTeetotallerflg { get; set; }

        [StringLength(1)]
        public string Matuser_BgCaresforpetsflg { get; set; }

        [StringLength(1)]
        public string Matuser_BgLikesreadingflg { get; set; }

        [StringLength(1)]
        public string Matuser_BgLikesliteratureflg { get; set; }

        public DateTime Matuser_CreateTS { get; set; }

        public DateTime Matuser_UpdateTS { get; set; }
    }
}
