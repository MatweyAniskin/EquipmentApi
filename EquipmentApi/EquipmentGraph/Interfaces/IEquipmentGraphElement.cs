namespace EquipmentApi.EquipmentGraph.Interfaces
{
    public interface IEquipmentGraphElement<T> : IEquipmentGraphRoot<T> where T : IEquipmentGraphElement<T>
    {
        int Id { get; }
        string Name { get; }        
    }
}
