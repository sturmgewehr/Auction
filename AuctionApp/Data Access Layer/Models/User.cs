using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        private string Password;

        public string PropPassword
        {
            get { return Password; }
            set
            {
                
                Password = value;
            }
        }

        [ForeignKey("ProfileId")]
        public Profile Profile { get; set; }
        [ForeignKey("ObjectsId")]
        public List<Object> Objects { get; set; }
        [ForeignKey("AuctionLots")]
        public List<AuctionLot> AuctionLots { get; set; }


    }
}
