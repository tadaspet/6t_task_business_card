using TestingNotesDAL.Entities;

namespace TestingNotesApiBLL.Interfaces
{
    public interface INoteServices
    {
        bool ChangeNoteCategory(Note note, int inputCategoryId);
        int CreateNewNote(Note note);
        void DeleteNote(int noteId);
        Note GetNoteByIdAndUser(int noteId, int userId);
        List<Note> GetNotesByCategoryId(int categoryId, int userId);
        List<Note> GetNoteSearchByTitle(string inputSearch, int userId);
        bool UpdateNote(Note note, int userId);
    }
}