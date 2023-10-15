using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class JobSeeker
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public char Gender { get; set; }
        public ICollection<Qualification> Qualifications { get; set; }
        public ICollection<Skill> Skills { get; set; }
        public ICollection<JobSeekerCV> JobSeekerCVs { get; set; }
        public int TotalExperience { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Mobile { get; set; }
        public string EMail { get; set; }        
        public string Profile { get; set; }
        public int Status { get; set; }
        public User User { get; set; }

    }
}
