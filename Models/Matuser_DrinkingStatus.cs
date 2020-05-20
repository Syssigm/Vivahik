namespace VivahikSearchApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Matuser_DrinkingStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Matuser_DrinkingStatus()
        {
            Matuser_HabitProfile = new HashSet<Matuser_HabitProfile>();
        }

        [Key]
        public int Matuser_DrinkingID { get; set; }

        [StringLength(50)]
        public string Matuser_DrinkingStatusdesc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Matuser_HabitProfile> Matuser_HabitProfile { get; set; }
    }
}
