using RegisterPersonApi.DAL.Entities;

namespace RegisterPersonApi.DAL.Repositories.Interfaces
{
    public interface IPersonInformationRepository
    {
        PersonInformation GetPersonalInformation(Guid userId);
        int AddNewPersonInformation(PersonInformation personInfo);
        bool UpdatePersonInformaiton(PersonInformation personInformation);
    }
}