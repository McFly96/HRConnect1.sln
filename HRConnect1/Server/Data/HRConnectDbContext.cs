using Microsoft.EntityFrameworkCore;
using HRConnect1.Shared.Models;
namespace HRConnect1.Server.Data


{
    public class HRConnectDbContext: DbContext
    {
        public HRConnectDbContext(DbContextOptions<HRConnectDbContext> options) : base(options) { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Qui puoi definire le configurazioni del modello del database, ad esempio:
            

            modelBuilder.Entity<Candidati>()
        .HasOne(c => c.ContrattoNavigation)
        .WithOne(c => c.CandidatiNavigation)
        .HasForeignKey<Contratto>(c => c.CandidatiID);

            modelBuilder.Entity<PosizioniAperte>()
        .HasOne(c => c.ContrattoNavigation)
        .WithOne(c => c.PosizioniAperteNavigation)
        .HasForeignKey<Contratto>(c => c.PosizioniAperteID);

            modelBuilder.Entity<Colloquio>()
                .HasOne(c => c.HRNavigation)
                .WithMany(c => c.Colloquios)
                .HasForeignKey(c => c.HRID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Colloquio>()
                .HasOne(c => c.SedeNavigation)
                .WithMany(c => c.Colloquios)
                .HasForeignKey(c => c.SedeID)
                .OnDelete(DeleteBehavior.NoAction);


            // Altre configurazioni del modello
        }

        public DbSet<Candidati> Candidatis { get; set; }
        public DbSet<Citta> Cittas { get; set; }
        public DbSet<Colloquio> Colloquios { get; set; }
        public DbSet<Contratto> Contrattos { get; set; }
        public DbSet<Dipendente> Dipendentes { get; set; }
        public DbSet<HardSkill> HardSkills { get; set; }
        public DbSet<SoftSkill> SoftSkills { get; set; }
        public DbSet<HR> HRs{ get; set; }
        public DbSet<PosizioniAperte> PosizioniApertes { get; set; }

        public DbSet<TitoloStudio> TitoloStudios { get; set; }
        public DbSet<Benefit> Benefits { get; set; }

    }
}
