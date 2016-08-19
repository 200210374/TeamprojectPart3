namespace TeamprojectPart3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("buy")]
    public partial class buy
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        public decimal price { get; set; }

        [Required]
        [StringLength(100)]
        public string descript { get; set; }
    }
}
