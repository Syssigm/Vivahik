namespace VivahikSearchApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Matuser_SmokingStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Matuser_SmokingStatus()
        {
            Matuser_HabitProfile = new HashSet<Matuser_HabitProfile>();
        }

        [Key]
        public int Matuser_SmokingID { get; set; }

        [StringLength(50)]
        public string Matuser_SmokingStatusdesc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Matuser_HabitProfile> Matuser_HabitProfile { get; set; }
    }
}
