using RegisterPersonApi.BLL.Services.Interfaces;
using RegisterPersonApi.DAL.Entities;
using RegisterPersonApi.DAL.Repositories.Interfaces;

namespace RegisterPersonApi.BLL.Services
{
    public class PersonInformaitonService : IPersonInformaitonService
    {
        private readonly IPersonInformationRepository _personRepo;

        public PersonInformaitonService(IPersonInformationRepository personRepo)
        {
            _personRepo = personRepo;
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
        public bool UpdatePersonInformaiton(PersonInformation personInfo)
        {
            var dbPerson = _personRepo.GetPersonalInformation(personInfo.UserId);
            if (dbPerson == null)
            {
                return false;
            }
            personInfo.LastModified = DateTime.Now;
            return _personRepo.UpdatePersonInformaiton(personInfo);
        }
    }
}
