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
                .ReverseMap();
        }
    }
}
