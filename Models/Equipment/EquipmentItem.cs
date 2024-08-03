using EquipmentApi.EquipmentGraph.Interfaces;

namespace EquipmentApi.Models.Equipment
{
    public class EquipmentItem : IEquipmentGraphElement<EquipmentItem>
    {
        public int Id {  get; set; }

        public string Name {  get; set; }

        public List<EquipmentItem> Nodes { get; set; } = new List<EquipmentItem>();
    }
}
