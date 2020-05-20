namespace VivahikSearchApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Matuser_Caste
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Matuser_Caste()
        {
            Matuser_ReligionProfile = new HashSet<Matuser_ReligionProfile>();
        }

        [Key]
        public int Matuser_ProfileCasteID { get; set; }

        [StringLength(30)]
        public string Matuser_Castename { get; set; }

        public int? Matuser_ReligionID { get; set; }

        [StringLength(20)]
        public string MatUser_ProfileIDGN { get; set; }

        public virtual Matuser_Religion Matuser_Religion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Matuser_ReligionProfile> Matuser_ReligionProfile { get; set; }
    }
}
