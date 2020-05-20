namespace VivahikSearchApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Matuser_Star
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Matuser_Star()
        {
            Matuser_Astrologicalprofile = new HashSet<Matuser_Astrologicalprofile>();
        }

        [Key]
        public int Matuser_ProfileStarID { get; set; }

        [StringLength(30)]
        public string Matuser_ProfileStarName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Matuser_Astrologicalprofile> Matuser_Astrologicalprofile { get; set; }
    }
}
