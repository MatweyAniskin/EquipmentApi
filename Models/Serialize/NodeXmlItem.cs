using System.Xml.Linq;
using System.Xml.Serialization;

namespace EquipmentApi.Models.Serialize
{
    public class NodeXmlItem
    {        
        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlElement("node")]
        public List<NodeXmlItem> Children { get; set; } = new List<NodeXmlItem>();
    }
}
