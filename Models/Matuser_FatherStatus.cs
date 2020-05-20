namespace VivahikSearchApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Matuser_FatherStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Matuser_FatherStatus()
        {
            Matuser_FamilyProfile = new HashSet<Matuser_FamilyProfile>();
        }

        public short Matuser_FatherstatusID { get; set; }

        [Required]
        [StringLength(30)]
        public string Matuser_Fatherstatusdesc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Matuser_FamilyProfile> Matuser_FamilyProfile { get; set; }
    }
}
