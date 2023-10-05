using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace qcs_product.API.Models
{
    public class Pasien
    {
        [Key] // Specifies that this property is the primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Specifies that the Id is auto-generated
        public int Id { get; set; }

        [Required] // Specifies that the Name property is required
        [MaxLength(50)] // Specifies the maximum length of the Name column
        public string Name { get; set; }

        [Column("DiseaseName")] // Specifies the column name in the database
        public string Disease { get; set; }

        [MaxLength(15)]
        public string Nik { get; set; }

        [EmailAddress] // Specifies that the Email property should be a valid email address
        public string Email { get; set; }

        [Phone] // Specifies that the NoHandphone property should be a valid phone number
        public string NoHandphone { get; set; }
    }
}
