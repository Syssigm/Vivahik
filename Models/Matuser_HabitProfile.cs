namespace VivahikSearchApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Matuser_HabitProfile
    {
        [Key]
        public int MatUser_HabitualID { get; set; }

        public DateTime? Create_ts { get; set; }

        public DateTime? Update_ts { get; set; }

        public int? Matuser_DrinkingID { get; set; }

        public int? Matuser_SmokingID { get; set; }

        public int? Matuser_EatingID { get; set; }

        [Required]
        [StringLength(20)]
        public string MatUser_ProfileIDGN { get; set; }

        public virtual Matuser_DrinkingStatus Matuser_DrinkingStatus { get; set; }

        public virtual Matuser_EatingStatus Matuser_EatingStatus { get; set; }

        public virtual Matuser_SmokingStatus Matuser_SmokingStatus { get; set; }
    }
}
