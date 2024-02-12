using Microsoft.EntityFrameworkCore;
using RegisterPersonApi.DAL.ApiDbContext;
using RegisterPersonApi.DAL.Entities;
using RegisterPersonApi.DAL.Repositories.Interfaces;

namespace RegisterPersonApi.DAL.Repositories
{
    public class PersonInformationRepository : IPersonInformationRepository
    {
        private readonly RegisterDbContext _context;

        public PersonInformationRepository(RegisterDbContext context)
        {
            _context = context;
        }
        public PersonInformation GetPersonalInformation(Guid userId)
        {
            var personInfo = _context.PersonInformations
                .Include(u => u.User)
                .Where(x => x.UserId == userId)
                .FirstOrDefault();
            if (personInfo == null)
            {
                return null;
            }
            return personInfo;
        }
        public int AddNewPersonInformation(PersonInformation personInfo)
        {
            _context.PersonInformations.Add(personInfo);
            _context.SaveChanges();
            return personInfo.Id;
        }
        public bool UpdatePersonInformation(PersonInformation personInformation)
        {
            var dbPersonInfo = _context.PersonInformations
                .FirstOrDefault(p => p.UserId == personInformation.UserId);
            if (dbPersonInfo == null)
            {
                return false;
            }
            dbPersonInfo.Name = personInformation.Name;
            dbPersonInfo.Surname = personInformation.Surname;
            dbPersonInfo.IdentityCode = personInformation.IdentityCode;
            dbPersonInfo.PhoneNo = personInformation.PhoneNo;
            dbPersonInfo.Email = personInformation.Email;
            dbPersonInfo.LastModified = personInformation.LastModified;

            _context.PersonInformations.Update(dbPersonInfo);
            _context.SaveChanges();

            return true;
        }
    }
}
