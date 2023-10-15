using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoratlServices.Interfaces
{
    public interface IAccountService
    {
        Task<User> Login(string UserID, string Password);
        Task<(bool, int)> RegisterEmployer(Employer employer);
        Task<(bool, int)> RegisterJobSeeker(JobSeeker jobSeeker);
        Task<bool> UpdateProfile(string url, int id, bool IsEmployer);
    }
}
