using Microsoft.EntityFrameworkCore;
using RegisterPersonApi.DAL.ApiDbContext;
using RegisterPersonApi.DAL.Entities;
using RegisterPersonApi.DAL.Repositories.Interfaces;

namespace RegisterPersonApi.DAL.Repositories
{
    public class SettlementRepository : ISettlementRepository
    {
        private readonly RegisterDbContext _context;

        public SettlementRepository(RegisterDbContext context)
        {
            _context = context;
        }
        public Settlement GetSettlement(Guid userId)
        {
            var settlementInfo = _context.Settlements
                .Include(p => p.PersonInformation)
                .ThenInclude(u => u.User)
                .Where(x => x.PersonInformation.User.Id == userId)
                .FirstOrDefault();
            if (settlementInfo == null)
            {
                return null;
            }
            return settlementInfo;
        }
        public int AddNewSettlement(Settlement settlement)
        {
            _context.Settlements.Add(settlement);
            _context.SaveChanges();
            return settlement.Id;
        }
        public bool UpdateSettlement(Settlement settlement)
        {
            var dbSettlementInfo = _context.Settlements
                .Include(p => p.PersonInformation)
                .FirstOrDefault(p => p.PersonInformation.Id == settlement.PersonInformationId);
            if (dbSettlementInfo == null)
            {
                return false;
            }
            dbSettlementInfo.City = settlement.City;
            dbSettlementInfo.Street = settlement.Street;
            dbSettlementInfo.BuildingNo = settlement.BuildingNo;
            dbSettlementInfo.FlatNo = settlement.FlatNo;
            dbSettlementInfo.LastModified = settlement.LastModified;

            _context.Settlements.Update(dbSettlementInfo);
            _context.SaveChanges();

            return true;
        }
    }
}
