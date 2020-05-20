namespace VivahikSearchApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Matuser_AgeRange
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Matuser_AgeRange()
        {
            Matuser_PhysicalProfile = new HashSet<Matuser_PhysicalProfile>();
        }

        public int Matuser_AgeRangeID { get; set; }

        public int? Matuser_Loweragelimit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Matuser_PhysicalProfile> Matuser_PhysicalProfile { get; set; }
    }
}
