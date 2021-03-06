namespace VivahikSearchApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Matuser_MessRequestAccptStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Matuser_MessRequestAccptStatus()
        {
            Matuser_MessageReceiver = new HashSet<Matuser_MessageReceiver>();
            Matuser_Messagesender = new HashSet<Matuser_Messagesender>();
        }

        [Key]
        public int MessageRequestStatusID { get; set; }

        [Required]
        [StringLength(20)]
        public string MessageRequestStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Matuser_MessageReceiver> Matuser_MessageReceiver { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Matuser_Messagesender> Matuser_Messagesender { get; set; }
    }
}
