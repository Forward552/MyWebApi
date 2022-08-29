

using Domain.Entities;
using Domain.Interfaces;
using Infrastracter.Data;

namespace Infrastracter.Repositories
{
    public class NoteRepository : INoteRepository
    {
        private readonly MyNotesContext _context;
        public NoteRepository(MyNotesContext contex)
        {
            _context = contex;
        }
 public IQueryable<Note> GetAll()
        {
            return _context.Notes;
        }

        public Note GetById(int id)
        {
        return _context.Notes.SingleOrDefault(x => x.Id == id);
        }

        public Note AddNote(Note note)
        {
            _context.Notes.Add(note);
            _context.SaveChanges();
            return note;
        }
        public void Update(Note note)
        {
            _context.Notes.Update(note);
            _context.SaveChanges();
        }

        public void Delete(Note note)
        {
            _context.Remove(note);
            _context.SaveChanges();
        }

       

    }
}
