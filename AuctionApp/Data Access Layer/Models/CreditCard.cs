using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Models
{
    public class CreditCard
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Index(IsUnique = true)]
        public int CreditCardNumber { get; set; }
        [ForeignKey("ProfileId")]
        [Required]
        public Profile Profile { get; set; }
    }
}
