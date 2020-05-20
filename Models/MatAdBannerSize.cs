namespace VivahikSearchApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MatAdBannerSize")]
    public partial class MatAdBannerSize
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MatAdBannerSize()
        {
            Matuser_AdDisplayImg = new HashSet<Matuser_AdDisplayImg>();
        }

        [Key]
        public int AdbannersizeID { get; set; }

        [StringLength(100)]
        public string AdBannertype { get; set; }

        [StringLength(100)]
        public string AdBannersize { get; set; }

        [StringLength(100)]
        public string AdBannershape { get; set; }

        public DateTime? Create_ts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Matuser_AdDisplayImg> Matuser_AdDisplayImg { get; set; }
    }
}
