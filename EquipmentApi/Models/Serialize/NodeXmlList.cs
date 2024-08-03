using System.Xml.Linq;
using System.Xml.Serialization;

namespace EquipmentApi.Models.Serialize
{
    [XmlRoot("nodes")]
    public class NodeXmlList
    {
        [XmlElement("node")]
        public List<NodeXmlItem> Nodes { get; set; } = new List<NodeXmlItem>();
    }
}
