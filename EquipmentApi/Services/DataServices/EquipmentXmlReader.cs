using AutoMapper;
using EquipmentApi.Models.Equipment;
using EquipmentApi.Models.Serialize;
using EquipmentApi.Services.Interfaces;
using System.Xml.Serialization;

namespace EquipmentApi.Services.DataServices
{
    public class EquipmentXmlReader : IEquipmentData
    {
        protected readonly string _xmlPath;
        protected readonly IMapper _mapper;
        public EquipmentXmlReader(IConfiguration configuration, IMapper mapper) 
        {
            _xmlPath = configuration.GetValue<string>("XmlEquipmentDataPath");
            _mapper = mapper;
        }
        public async Task<EquipmentRoot> GetEquipmentDataAsync() => Read(await File.ReadAllTextAsync(_xmlPath));
        public EquipmentRoot GetEquipmentData() => Read(File.ReadAllText(_xmlPath));        
        protected EquipmentRoot Read(string xmlData)
        {           
            var serializer = new XmlSerializer(typeof(NodeXmlList));
            using (var reader = new StringReader(xmlData))
            {
                var data = (NodeXmlList)serializer.Deserialize(reader);
                return _mapper.Map<EquipmentRoot>(data);
            }            
        }
    }
}
