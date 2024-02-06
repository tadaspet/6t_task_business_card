using RegisterPersonApi.DAL.Entities;

namespace RegisterPersonApi.DAL.Repositories.Interfaces
{
    public interface ISettlementRepository
    {
        int AddNewSetllement(Settlement settlement);
        Settlement GetSettlement(Guid userId);
        bool UpdateSettlement(Settlement settlement);
    }
}