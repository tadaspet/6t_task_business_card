using RegisterPersonApi.BLL.Services.Interfaces;
using RegisterPersonApi.DAL.Entities;
using RegisterPersonApi.DAL.Repositories.Interfaces;

namespace RegisterPersonApi.BLL.Services
{
    public class SettlementService : ISettlementService
    {
        private readonly ISettlementRepository _settlRepo;

        public SettlementService(ISettlementRepository settlRepo)
        {
            _settlRepo = settlRepo;
        }

        public Settlement GetSettlement(Guid userId)
        {
            return _settlRepo.GetSettlement(userId);
        }

        public int AddNewSetllement(Settlement settlement, Guid userId)
        {
            var hasDbSettlement = _settlRepo.GetSettlement(userId);
            if (hasDbSettlement != null)
            {
                return 0;
            }
            settlement.CreationDate = DateTime.Now;

            return _settlRepo.AddNewSetllement(settlement);
        }

        public bool UpdateSettlement(Settlement settlement, Guid userId)
        {
            var hasDbSettlement = _settlRepo.GetSettlement(userId);
            if (hasDbSettlement == null)
            {
                return false;
            }
            settlement.LastModified = DateTime.Now;

            return _settlRepo.UpdateSettlement(settlement);
        }
    }
}
