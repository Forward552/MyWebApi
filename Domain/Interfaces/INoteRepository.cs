using Domain.Entities;

namespace Domain.Interfaces
{
    public interface INoteRepository
    {
        IQueryable<Note> GetAll();
        Note GetById(int id);
        Note AddNote(Note note);
        public void Update(Note note);
        public void Delete(Note note);


    }
}
