using RegisterPersonApi.DAL.Entities;

namespace RegisterPersonApi.DAL.Repositories.Interfaces
{
    public interface ISettlementRepository
    {
        int AddNewSettlement(Settlement settlement);
        Settlement GetSettlement(Guid userId);
        bool UpdateSettlement(Settlement settlement);
    }
}