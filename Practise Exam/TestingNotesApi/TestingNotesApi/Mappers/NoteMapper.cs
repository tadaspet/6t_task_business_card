using KeepNotesDAL.Entities;
using TestingNotesApi.DTOs;
using TestingNotesApi.Interfaces;
using TestingNotesDAL.Entities;

namespace TestingNotesApi.Mappers
{
    public class NoteMapper : INoteMapper
    {
        private readonly IImageFileMapper _imageFileMapper;

        public NoteMapper(IImageFileMapper imageFileMapper)
        {
            _imageFileMapper = imageFileMapper;
        }

        public Note Map(NoteGetDTO dto)
        {
            var note = new Note
            {
                Title = dto.Title,
                Content = dto.Content,
                NoteCategoryId = dto.NoteCategoryId,
            };
            return note;
        }
        public Note Map(int noteId, NoteUpdateDTO dto)
        {
            var note = new Note
            {
                Id = noteId,
                Title = dto.Title,
                Content = dto.Content,
            };
            return note;
        }
        public NotePushDTO Map(Note entity)
        {
            var dto = new NotePushDTO
            {
                NoteCategoryId = entity.NoteCategoryId,
                Title = entity.Title,
                Content = entity.Content,
                CreationDate = entity.CreationDate,
                LastModifiedDate = entity.LastModifiedDate,
            };
            return dto;
        }

        public List<NotePushDTO> Map(List<Note> listEntity)
        {
            return listEntity.Select(Map).ToList();
        }
    }
}
