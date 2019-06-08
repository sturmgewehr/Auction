using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Models
{
    public class AuctionLot
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("ObjectId")]
        public Object Object { get; set; }
        [Required]
        [ForeignKey("UsersId")]
        public List<User> Users { get; set; }
    }
}
