using TestingNotesApiBLL.Interfaces;
using TestingNotesDAL.Entities;
using TestingNotesDAL.Interfacees;
using TestingNotesDAL.Repositories;

namespace TestingNotesApiBLL.Services
{
    public class NoteServices : INoteServices
    {
        private readonly INoteRepository _repositoryNotes;

        public NoteServices(INoteRepository repository)
        {
            _repositoryNotes = repository;
        }
        public int CreateNewNote(Note note)
        {
            var noteId = _repositoryNotes.SaveNewNote(note);
            return noteId;
        }

        public Note GetNoteByIdAndUser(int noteId, int userId)
        {
            return _repositoryNotes.GetNoteByIdAndUser(noteId, userId);
        }
        public bool UpdateNote(Note note, int userId)
        {
            var existingNote = _repositoryNotes.GetNoteByIdAndUser(note.Id, userId);
            if (existingNote is null)
            {
                return false;
            }
            _repositoryNotes.UpdateNote(note);
            return true;
        }
        public void DeleteNote(int noteId)
        {
            _repositoryNotes.DeleteNote(noteId);
        }
        public bool ChangeNoteCategory(Note note, int inputCategoryId)
        {
            var categoryChange = _repositoryNotes.ChangeNoteCategory(note, inputCategoryId);
            if (!categoryChange)
            {
                return false;
            }
            return true;
        }
        public List<Note> GetNoteSearchByTitle(string inputSearch, int userId)
        {
            return _repositoryNotes.GetNotesByName(inputSearch, userId);
        }
        public List<Note> GetNotesByCategoryId(int categoryId, int userId)
        {
            return _repositoryNotes.GetNotesByCategoryId(categoryId, userId);
        }
    }
}
