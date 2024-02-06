using RegisterPersonApi.DAL.Entities;

namespace RegisterPersonApi.BLL.Services.Interfaces
{
    public interface ISettlementService
    {
        int AddNewSetllement(Settlement settlement, Guid userId);
        Settlement GetSettlement(Guid userId);
        bool UpdateSettlement(Settlement settlement, Guid userId);
    }
}