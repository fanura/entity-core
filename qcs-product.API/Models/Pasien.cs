using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace qcs_product.API.Models
{
    public class Pasien
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int Id { get; set; }

        [Required] 
        [MaxLength(50)] 
        public string Name { get; set; }

        [Column("DiseaseName")] 
        public string Disease { get; set; }

        [MaxLength(15)]
        public string Nik { get; set; }

        [EmailAddress] 
        public string Email { get; set; }

        [Phone] 
        public string NoHandphone { get; set; }
    }
}
