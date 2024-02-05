using KeepNotesDAL.Entities;
using TestingNotesDAL.Entities;

namespace TestingNotesDAL.Interfacees
{
    public interface INoteRepository
    {
        bool ChangeNoteCategory(Note note, int inputCategoryId);
        void DeleteNote(int inputNoteId);
        //Note GetCategoryById(int inputNoteId);
        Note GetNoteByIdAndUser(int inputNoteId, int userId);
        int SaveNewNote(Note note);
        int UpdateNote(Note note);
        List<Note> GetNotesByName(string inputSearch, int userId);
        List<Note> GetNotesByCategoryId(int categoryId, int userId);
    }
}