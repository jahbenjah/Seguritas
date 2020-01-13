using Seguritas.Core;
using System.Data.Entity;

namespace Seguritas.Api

{
    public partial class SeguritasContext : DbContext
    {
        public SeguritasContext()
            : base("name=SeguritasContext")
        {
        }

        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Coberturas> Coberturas { get; set; }
        public virtual DbSet<Planes> Planes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clientes>()
                .HasMany(e => e.Planes)
                .WithMany(e => e.Clientes)
                .Map(m => m.ToTable("ClientePlanes").MapLeftKey("ClienteId").MapRightKey("PlanId"));

            modelBuilder.Entity<Coberturas>()
                .HasMany(e => e.Planes)
                .WithMany(e => e.Coberturas)
                .Map(m => m.ToTable("PlanesCoberturas").MapLeftKey("CoberturaId").MapRightKey("PlanId"));
        }
    }
}
