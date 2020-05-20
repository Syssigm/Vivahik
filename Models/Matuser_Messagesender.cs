namespace VivahikSearchApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Matuser_Messagesender
    {
        public int Matuser_MessageSenderID { get; set; }

        [StringLength(30)]
        public string Matuser_ReceiverProfileID { get; set; }

        [StringLength(30)]
        public string Matuser_SenderProfileID { get; set; }

        public int? Matuser_Messagetypeid { get; set; }

        public int? Matuser_ReqacceptancestatusID { get; set; }

        public int? Matuser_ReadstatusID { get; set; }

        public string Matuser_Message { get; set; }

        public DateTime? Matuser_sentts { get; set; }

        [StringLength(1)]
        public string Matuser_Firsttimeflag { get; set; }

        public virtual Matuser_Messagereadstatus Matuser_Messagereadstatus { get; set; }

        public virtual Matuser_Messagetype Matuser_Messagetype { get; set; }

        public virtual Matuser_MessRequestAccptStatus Matuser_MessRequestAccptStatus { get; set; }
    }
}
