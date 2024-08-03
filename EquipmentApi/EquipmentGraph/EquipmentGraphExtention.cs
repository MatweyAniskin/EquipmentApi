using EquipmentApi.EquipmentGraph.Interfaces;

namespace EquipmentApi.EquipmentGraph
{
    public static class EquipmentGraphExtention
    {
        public static int GetNodeIdByPath<T>(this IEquipmentGraphElement<T> equipmentGraph, Queue<string> path) where T : IEquipmentGraphElement<T>
        {
            if (path.Count == 0)
                return equipmentGraph.Id;
            return equipmentGraph.Nodes.FindNode(path);
        }
        public static int GetNodeIdByPath<T>(this IEquipmentGraphRoot<T> equipmentGraph, IEnumerable<string> path) where T : IEquipmentGraphElement<T>
        {
            return equipmentGraph.Nodes.FindNode(new Queue<string>(path));
        }
        private static int FindNode<T>(this IEnumerable<T> nodes, Queue<string> path) where T : IEquipmentGraphElement<T>
        {
            var currentName = path.Dequeue();
            return nodes.FirstOrDefault(n => n.Name == currentName)?.GetNodeIdByPath(path) ?? -1;
        }
    }
}
