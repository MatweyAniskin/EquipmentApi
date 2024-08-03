using EquipmentApi.EquipmentGraph.Interfaces;

namespace EquipmentApi.EquipmentGraph
{
    public static class EquipmentGraphExtention
    {
        public static int GetNodeIdByPath<T>(this IEquipmentGraphElement<T> equipmentGraph, Queue<string> path) where T : IEquipmentGraphElement<T>
        {
            if (path.Count == 0)
                return equipmentGraph.Id;
            return FindNode<T>(equipmentGraph.Nodes, path);
        }
        public static int GetNodeIdByPath<T>(this IEquipmentGraphRoot<T> equipmentGraph, Queue<string> path) where T : IEquipmentGraphElement<T>
        {
            return FindNode<T>(equipmentGraph.Nodes, path);
        }
        private static int FindNode<T>(List<T> nodes, Queue<string> path) where T : IEquipmentGraphElement<T>
        {
            var currentName = path.Dequeue();
            return nodes.FirstOrDefault(n => n.Name == currentName)?.GetNodeIdByPath(path) ?? -1;
        }
    }
}
