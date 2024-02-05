using RegisterPersonApi.BLL.Services.Interfaces;
using RegisterPersonApi.DAL.Entities;
using RegisterPersonApi.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterPersonApi.BLL.Services
{
    public class PersonInformaitonService : IPersonInformaitonService
    {
        private readonly IPersonInformationRepository _personRepo;

        public PersonInformaitonService(IPersonInformationRepository personRepo)
        {
            _personRepo = personRepo;
        }
        public PersonInformation GetPersonalInformation(Guid personId)
        {
            return _personRepo.GetPersonalInformation(personId);
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
