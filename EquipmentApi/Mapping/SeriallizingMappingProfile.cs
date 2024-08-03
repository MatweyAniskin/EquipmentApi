using EquipmentApi.Models.Equipment;
using EquipmentApi.Models.Serialize;

namespace EquipmentApi.Mapping
{
    public class SeriallizingMappingProfile : AutoMapper.Profile
    {
        public SeriallizingMappingProfile()
        {
            CreateMap<NodeXmlItem,EquipmentItem>().ForMember(dest => dest.Nodes,opt => opt.MapFrom(src => src.Children));
            CreateMap<NodeXmlList, EquipmentRoot>();
        }
    }
}
