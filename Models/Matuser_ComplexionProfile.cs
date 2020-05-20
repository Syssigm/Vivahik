namespace VivahikSearchApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Matuser_ComplexionProfile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Matuser_ComplexionProfile()
        {
            Matuser_PhysicalProfile = new HashSet<Matuser_PhysicalProfile>();
        }

        [Key]
        public int Matuser_ProfilecomplexionID { get; set; }

        [Required]
        [StringLength(30)]
        public string Matuser_Profilecomplexionname { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Matuser_PhysicalProfile> Matuser_PhysicalProfile { get; set; }
    }
}
