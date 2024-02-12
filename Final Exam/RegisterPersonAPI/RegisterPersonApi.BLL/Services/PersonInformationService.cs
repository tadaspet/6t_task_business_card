using RegisterPersonApi.BLL.Services.Interfaces;
using RegisterPersonApi.DAL.Entities;
using RegisterPersonApi.DAL.Repositories.Interfaces;

namespace RegisterPersonApi.BLL.Services
{
    public class PersonInformationService : IPersonInformaitonService
    {
        private readonly IPersonInformationRepository _personRepo;

        public PersonInformationService(IPersonInformationRepository personRepository)
        {
            _personRepo = personRepository;
        }
        public PersonInformation GetPersonalInformation(Guid userId)
        {
            return _personRepo.GetPersonalInformation(userId);
        }
        public int AddNewPersonInformation(PersonInformation personInfo)
        {
            var dbPerson = _personRepo.GetPersonalInformation(personInfo.UserId);
            if (dbPerson != null)
            {
                return 0;
            }
            personInfo.CreationDate = DateTime.Now;
            return _personRepo.AddNewPersonInformation(personInfo);
        }
        public bool UpdatePersonInformation(PersonInformation personInfo)
        {
            var dbPerson = _personRepo.GetPersonalInformation(personInfo.UserId);
            if (dbPerson == null)
            {
                return false;
            }
            personInfo.LastModified = DateTime.Now;
            return _personRepo.UpdatePersonInformation(personInfo);
        }
    }
}
