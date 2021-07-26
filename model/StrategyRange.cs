namespace MopckPurchaseOrder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StrategyRange")]
    public partial class StrategyRange
    {
        public int Id { get; set; }

        public int StrategyId { get; set; }

        public int Type { get; set; }

        public int Mode { get; set; }

        public int ItemId { get; set; }

        [Required]
        [StringLength(200)]
        public string ItemName { get; set; }

        public int? Extend1 { get; set; }

        [StringLength(200)]
        public string Extend2 { get; set; }

        public int Category { get; set; }
    }
}
