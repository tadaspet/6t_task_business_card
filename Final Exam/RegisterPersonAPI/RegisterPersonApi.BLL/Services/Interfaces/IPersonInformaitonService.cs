using RegisterPersonApi.DAL.Entities;

namespace RegisterPersonApi.BLL.Services.Interfaces
{
    public interface IPersonInformaitonService
    {
        int AddNewPersonInformation(PersonInformation personInfo);
        PersonInformation GetPersonalInformation(Guid personId);
        bool UpdatePersonInformation(PersonInformation personInfo);
    }
}