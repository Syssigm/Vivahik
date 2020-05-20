namespace VivahikSearchApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MatuserFamily_Type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MatuserFamily_Type()
        {
            Matuser_FamilyProfile = new HashSet<Matuser_FamilyProfile>();
        }

        [Key]
        public int Matuser_FamilyTypeID { get; set; }

        [StringLength(50)]
        public string Matuser_FamilyType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Matuser_FamilyProfile> Matuser_FamilyProfile { get; set; }
    }
}
