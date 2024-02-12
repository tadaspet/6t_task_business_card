using RegisterPersonApi.DAL.Entities;

namespace RegisterPersonApi.BLL.Services.Interfaces
{
    public interface ISettlementService
    {
        int AddNewSettlement(Settlement settlement, Guid userId);
        Settlement GetSettlement(Guid userId);
        bool UpdateSettlement(Settlement settlement, Guid userId);
    }
}