namespace EquipmentApi.EquipmentGraph.Interfaces
{
    public interface IEquipmentGraphRoot<T> where T : IEquipmentGraphElement<T>
    {
        List<T> Nodes { get; }
    }
}
