namespace Data_Access_Layer
{
    using Data_Access_Layer.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Object = Models.Object;

    public class AppContext : DbContext
    {
        public AppContext()
            : base("name=AppContext")
        {

        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<Object> Objects { get; set; }
        public virtual DbSet<CreditCard> CreditCards { get; set; }
        public virtual DbSet<AuctionLot> AuctionLots { get; set; }


    }
}