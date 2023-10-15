using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class User
    {
        public int Id { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public bool IsEmployer { get; set; }=false;
        public virtual Employer Employer { get; set; }
        public virtual JobSeeker JobSeeker { get; set; }
    }
}
