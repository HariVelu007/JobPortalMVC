using AutoMapper;
using DomainModel;
using JobPortal.Models.Account;
using JobPortal.Models.Home;

namespace JobPortal.PortalConfig
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles()
        {
            CreateMap<Employer, EmployerRegViewModel>()
                .ForMember(s=>s.Password, x=>x.MapFrom(t=>t.User.Password))
                .ForMember(s=>s.EMail,x=>x.MapFrom(t=>t.User.EMail))
                .BeforeMap((s,t)=>s.User.IsEmployer=true)
                .ReverseMap();

            CreateMap<JobSeeker, HUserSideBarViewModel>().ReverseMap();

            CreateMap<JobSeeker, JobSeekerRegViewModel>()
                .ForMember(s => s.Password, x => x.MapFrom(t => t.User.Password))
                .ForMember(s => s.EMail, x => x.MapFrom(t => t.User.EMail))
                .BeforeMap((s, t) => s.User.IsEmployer = false)
                .ReverseMap();
            
        }
    }
}
