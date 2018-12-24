namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Notation")]
    public partial class Notation
    {
        public int ID { get; set; }

        public int Project_ID { get; set; }

        [StringLength(1000)]
        public string Note { get; set; }

        public int Author { get; set; }

        public DateTime Date { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Project Project { get; set; }
    }
}
