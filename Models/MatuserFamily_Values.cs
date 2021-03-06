namespace VivahikSearchApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MatuserFamily_Values
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MatuserFamily_Values()
        {
            Matuser_FamilyProfile = new HashSet<Matuser_FamilyProfile>();
        }

        [Key]
        public int Matuser_FamilyValuesID { get; set; }

        [StringLength(50)]
        public string Matuser_Familyvalues { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Matuser_FamilyProfile> Matuser_FamilyProfile { get; set; }
    }
}
