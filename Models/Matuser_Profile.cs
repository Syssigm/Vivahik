namespace VivahikSearchApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Matuser_Profile
    {
        public int MatUser_ProfileID { get; set; }

        public int MatUser_ProfileForID { get; set; }

        [Required]
        [StringLength(50)]
        public string MatUser_FirstName { get; set; }

        [StringLength(50)]
        public string MatUser_LastName { get; set; }

        [Column(TypeName = "date")]
        public DateTime MatUser_DOB { get; set; }

        [Required]
        [StringLength(7)]
        public string MatUser_Gender { get; set; }

        public int? MatUser_ProfileRelCastSubcastID { get; set; }

        public int? MatUser_MotherTongueID { get; set; }

        public int? MatUser_MaritalStatusID { get; set; }

        public int? MatUser_PhysicaldetID { get; set; }

        public int? MatUser_ProfileaddressID { get; set; }

        public int? MatUser_AstrologicalID { get; set; }

        public int? MatUser_OccupationalID { get; set; }

        public int? MatUser_HabitualID { get; set; }

        public int? MatUser_FamilydetID { get; set; }

        public int MatUser_LoginID { get; set; }

        public int MatUser_PlanID { get; set; }

        public int? Matuser_PhotoID { get; set; }

        public int? Matuser_ResidentstatusID { get; set; }

        public string Comments { get; set; }

        public DateTime Create_ts { get; set; }

        public DateTime Update_ts { get; set; }

        [Required]
        [StringLength(20)]
        public string MatUser_ProfileIDGN { get; set; }

        public int? Matuser_BgPerIntID { get; set; }
    }
}
