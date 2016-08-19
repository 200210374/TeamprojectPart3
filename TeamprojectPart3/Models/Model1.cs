namespace TeamprojectPart3.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<buy> buys { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<buy>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<buy>()
                .Property(e => e.price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<buy>()
                .Property(e => e.descript)
                .IsFixedLength();
        }
    }
}
