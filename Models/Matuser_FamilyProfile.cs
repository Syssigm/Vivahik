namespace VivahikSearchApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Matuser_FamilyProfile
    {
        [Key]
        public int MatUser_FamilydetID { get; set; }

        public int? Matuser_FamilyStatusID { get; set; }

        public int? Matuser_FamilyTypeID { get; set; }

        public int? Matuser_FamilyValuesID { get; set; }

        public short? Matuser_FatherstatusID { get; set; }

        [Required]
        [StringLength(20)]
        public string MatUser_ProfileIDGN { get; set; }

        public virtual Matuser_FatherStatus Matuser_FatherStatus { get; set; }

        public virtual MatuserFamily_Status MatuserFamily_Status { get; set; }

        public virtual MatuserFamily_Type MatuserFamily_Type { get; set; }

        public virtual MatuserFamily_Values MatuserFamily_Values { get; set; }
    }
}
