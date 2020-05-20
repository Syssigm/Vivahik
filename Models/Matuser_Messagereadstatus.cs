namespace VivahikSearchApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Matuser_Messagereadstatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Matuser_Messagereadstatus()
        {
            Matuser_MessageReceiver = new HashSet<Matuser_MessageReceiver>();
            Matuser_Messagesender = new HashSet<Matuser_Messagesender>();
        }

        public int Matuser_MessagereadstatusID { get; set; }

        [StringLength(30)]
        public string Matuser_Messagerequeststatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Matuser_MessageReceiver> Matuser_MessageReceiver { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Matuser_Messagesender> Matuser_Messagesender { get; set; }
    }
}
