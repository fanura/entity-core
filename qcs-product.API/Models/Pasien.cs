using System;
/*using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;*/


namespace qcs_product.API.Models
{
    public class Pasien
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Disease { get; set; }
        public string Nik { get; set; }
        public string Email { get; set; }
        public string NoHandphone { get; set; }

    }
}