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

    }
}
