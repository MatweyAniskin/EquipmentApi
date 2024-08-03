using EquipmentApi.Models.Equipment;
using EquipmentApi.Models.Serialize;

namespace EquipmentApi.Services.Interfaces
{
    public interface IEquipmentData
    {
        Task<EquipmentRoot> GetEquipmentDataAsync();
        EquipmentRoot GetEquipmentData();
    }
}
