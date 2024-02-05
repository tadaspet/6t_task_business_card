using KeepNotesDAL.AppDbContext;
using KeepNotesDAL.Entities;
using Microsoft.EntityFrameworkCore;
using TestingNotesDAL.Entities;
using TestingNotesDAL.Interfacees;

namespace TestingNotesDAL.Repositories
{
    public class NoteRepository : INoteRepository
    {
        private readonly NotesDbContext _context;

        public NoteRepository(NotesDbContext context)
        {
            _context = context;
        }

        public int SaveNewNote(Note note)
        {
            note.CreationDate = DateTime.Now;
            _context.Notes.Add(note);
            _context.SaveChanges();

            return note.Id;
        }
        public Note GetNoteByIdAndUser(int inputNoteId, int userId)
        {
            var note = _context.Notes
                .Include(n => n.NoteCategory)
                .ThenInclude(c => c.User)
                .FirstOrDefault(n => n.Id == inputNoteId && n.NoteCategory.UserId == userId);

            var noteUserId = _context.Notes
                .Where(n => n.Id == inputNoteId)
                .Select(n => n.NoteCategory.UserId)
                .FirstOrDefault();

            if (note is null || noteUserId != userId)
            {
                return null;
            }
            return note;
        }

        public void DeleteNote(int inputNoteId)
        {
            var note = _context.Notes.Find(inputNoteId);
            _context.Notes.Remove(note);
            _context.SaveChanges();
        }
        public int UpdateNote(Note note)
        {
            var existingNote = _context.Notes.FirstOrDefault(c => c.Id == note.Id);
            existingNote.Title = note.Title;
            existingNote.Content = note.Content;
            existingNote.LastModifiedDate = DateTime.Now;
            _context.Notes.Update(existingNote);
            _context.SaveChanges();

            return existingNote.Id;
        }

        public bool ChangeNoteCategory(Note note, int inputCategoryId)
        {
            var category = _context.NoteCategories.FirstOrDefault(c => c.Id == inputCategoryId);
            if (category is null)
            {
                return false;
            }
            note.NoteCategoryId = inputCategoryId;
            note.NoteCategory = category;
            _context.Notes.Update(note);
            _context.SaveChanges();
            return true;
        }

        public List<Note> GetNotesByName(string inputSearch, int userId)
        {
            var notes = _context.Notes
                .Include(n => n.NoteCategory)
                .ThenInclude(c => c.User)
                .Where(n => n.NoteCategory.UserId == userId)
                .ToList();
            return notes.Where(n => n.Title.Contains(inputSearch)).ToList(); 
        }

        public List<Note> GetNotesByCategoryId(int categoryId, int userId)
        {
            var notes = _context.Notes
                .Include(n => n.NoteCategory)
                .ThenInclude(c => c.User)
                .Where(n => n.NoteCategory.UserId == userId && n.NoteCategoryId == categoryId)
                .ToList();
            return notes;
        }

    }
}
