using DomainModel;
using Microsoft.EntityFrameworkCore;
using PoratlServices.Config;
using PoratlServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoratlServices.Implementations
{
    public class AccountService : IAccountService
    {
        private readonly JpContext _JpContext;
        public AccountService(JpContext JpContext) 
        {
            _JpContext = JpContext;
        }
        public async Task<(bool,User)> Login(string UserID, string Password)
        {
            User user= await _JpContext.Users.Where(e=>e.EMail.Equals(UserID) && e.Password.Equals(Password)).SingleOrDefaultAsync();
            bool res= user!=null?true:false;
            return (res,user);
        }
        public async Task<(bool,int)> RegisterEmployer(Employer employer)
        {            
            _JpContext.Employers.Add(employer);
            var res=await _JpContext.SaveChangesAsync();

            return (res>0?true:false, employer.ID);
        }
        public async Task<(bool, int)> RegisterJobSeeker(JobSeeker jobSeeker)
        {
            _JpContext.JobSeekers.Add(jobSeeker);
            int res = await _JpContext.SaveChangesAsync();

            return (res > 0 ? true : false, jobSeeker.ID);
        }
        public async Task<bool> UpdateProfile(string url, int id, bool IsEmployer)
        {
            if(IsEmployer)
            {
                Employer emp = await _JpContext.Employers.Where(e => e.ID.Equals(id)).SingleOrDefaultAsync();
                emp.Logo = url;
                _JpContext.Employers.Update(emp);
            }
            else
            {
                JobSeeker seeker = await _JpContext.JobSeekers.Where(e => e.ID.Equals(id)).SingleOrDefaultAsync();
                seeker.Profile = url;
                _JpContext.JobSeekers.Update(seeker);
            }           

            return await _JpContext.SaveChangesAsync()>0?true:false;
        }
    }
}
