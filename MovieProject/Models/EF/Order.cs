namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        public long ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreateDate { get; set; }

        public long? CustomerID { get; set; }

        [StringLength(50)]
        public string Movie { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [StringLength(50)]
        public string Cinema { get; set; }

        [StringLength(50)]
        public string AvaibleSit { get; set; }

        [StringLength(50)]
        public string OrderedSit { get; set; }
    }
}
