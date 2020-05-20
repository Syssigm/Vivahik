namespace VivahikSearchApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Matuser_PhysicalProfile
    {
        public int Matuser_PhysicalProfileID { get; set; }

        public int Matuser_ProfileweightID { get; set; }

        public int Matuser_ProfileheightID { get; set; }

        public int Matuser_ProfilecomplexionID { get; set; }

        public int? Matuser_ProfilephysicalstatusID { get; set; }

        public int? Matuser_AgeRangeID { get; set; }

        public int? Matuser_BodyTypeID { get; set; }

        [Required]
        [StringLength(20)]
        public string MatUser_ProfileIDGN { get; set; }

        public virtual Matuser_AgeRange Matuser_AgeRange { get; set; }

        public virtual Matuser_BodyType Matuser_BodyType { get; set; }

        public virtual Matuser_ComplexionProfile Matuser_ComplexionProfile { get; set; }

        public virtual Matuser_HeightProfile Matuser_HeightProfile { get; set; }

        public virtual Matuser_PhysicalStatus Matuser_PhysicalStatus { get; set; }

        public virtual Matuser_WeightProfile Matuser_WeightProfile { get; set; }
    }
}
