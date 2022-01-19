using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Village_Program.Models
{
    public partial class VillageContext : DbContext
    {
        public VillageContext()
            : base("name=VillageContext")
        {
        }

        public virtual DbSet<Citizen> Citizens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
