using AutoMapper;
using DomainModel;
using JobPortal.Models.Account;

namespace JobPortal.PortalConfig
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles()
        {
            CreateMap<Employer, EmployerRegViewModel>()
                .ForMember(s=>s.Password, x=>x.MapFrom(t=>t.User.Password))
                .ForMember(s=>s.EMail,x=>x.MapFrom(t=>t.User.EMail))
                .ReverseMap();
            
        }
    }
}
