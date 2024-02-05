using TestingNotesApi.DTOs;
using TestingNotesDAL.Entities;

namespace TestingNotesApi.Interfaces
{
    public interface INoteMapper
    {
        Note Map(NoteGetDTO dto);
        NotePushDTO Map(Note entity);
        Note Map(int noteId, NoteUpdateDTO dto);
        List<NotePushDTO> Map(List<Note> listEntity);
    }
}