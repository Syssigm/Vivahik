namespace VivahikSearchApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Matuser_PhysicalStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Matuser_PhysicalStatus()
        {
            Matuser_PhysicalProfile = new HashSet<Matuser_PhysicalProfile>();
        }

        [Key]
        public int Matuser_ProfilephysicalstatusID { get; set; }

        [Required]
        [StringLength(30)]
        public string Matuser_Profilephysicalstatusdesc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Matuser_PhysicalProfile> Matuser_PhysicalProfile { get; set; }
    }
}
