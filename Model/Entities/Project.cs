namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Project")]
    public partial class Project
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Project()
        {
            Notations = new HashSet<Notation>();
            Participations = new HashSet<Participation>();
        }

        public int ID { get; set; }

        public int? Cost { get; set; }

        public int Status_ID { get; set; }

        [StringLength(200)]
        public string web_address { get; set; }

        public int? Head { get; set; }

        public int Service_ID { get; set; }

        public int Customer_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public DateTime Date { get; set; }

        public DateTime? EndDate { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Notation> Notations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Participation> Participations { get; set; }

        public virtual Service Service { get; set; }

        public virtual Status Status { get; set; }
    }
}
