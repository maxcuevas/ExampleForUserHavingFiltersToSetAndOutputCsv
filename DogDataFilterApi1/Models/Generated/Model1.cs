namespace DogDataFilterApi.Models.Generated
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

        public virtual DbSet<csvWithDataVersion1> csvWithDataVersion1 { get; set; }
        public virtual DbSet<csvWithDataVersion2> csvWithDataVersion2 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
