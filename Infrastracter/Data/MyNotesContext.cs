using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastracter.Data
{
    public class MyNotesContext : DbContext
    {
        //Tutaj mogę wskazać provaidera dostawce tajkiegoi jak sql serwer
        public MyNotesContext(DbContextOptions options) : base(options)
        {

        }
        //DbSet obiekt który bedzie mapowany na tabelę bazo danową stąd bedziemy uzyskiwać dostęp do notatek
        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {//wskazujemy nazwę tabeli

            modelBuilder.Entity<Note>().ToTable("Notes");
            modelBuilder.Entity<Note>().HasKey(x => x.Id);
            modelBuilder.Entity<Note>().Property(x => x.Title).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Note>().Property(x => x.Content).HasMaxLength( 2000);
        }

    }
}
