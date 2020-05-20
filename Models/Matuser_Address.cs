namespace VivahikSearchApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Matuser_Address
    {
        [Key]
        public int MatUser_ProfileaddressID { get; set; }

        [StringLength(15)]
        public string AddressType { get; set; }

        [StringLength(20)]
        public string PhoneNumberTaggedToAddress { get; set; }

        [StringLength(50)]
        public string EmailTaggedToAddress { get; set; }

        [StringLength(10)]
        public string BuildingNumber { get; set; }

        [StringLength(100)]
        public string StreetName1 { get; set; }

        [StringLength(100)]
        public string StreetName2 { get; set; }

        [StringLength(40)]
        public string CityName { get; set; }

        [StringLength(25)]
        public string State { get; set; }

        [StringLength(12)]
        public string Zipcode { get; set; }

        public int? CntID { get; set; }

        [StringLength(1)]
        public string AddressStatus { get; set; }

        public DateTime? Registered_ts { get; set; }

        public DateTime? Updated_ts { get; set; }
    }
}
