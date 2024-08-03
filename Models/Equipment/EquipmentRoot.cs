using EquipmentApi.EquipmentGraph.Interfaces;

namespace EquipmentApi.Models.Equipment
{
    public class EquipmentRoot : IEquipmentGraphRoot<EquipmentItem>
    {
        public List<EquipmentItem> Nodes {  get; set; } = new List<EquipmentItem>();
    }
}
