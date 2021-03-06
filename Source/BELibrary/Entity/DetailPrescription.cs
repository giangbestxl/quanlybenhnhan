namespace BELibrary.Entity
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("DetailPrescription")]
    public partial class DetailPrescription
    {
        public Guid Id { get; set; }

        public int Amount { get; set; }

        [Required]
        [StringLength(50)]
        public string Unit { get; set; }

        [Required]
        public string Note { get; set; }

        public Guid MedicineId { get; set; }

        public virtual Medicine Medicine { get; set; }
    }
}