using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Job
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string JobTitle { get; set; }
        public List<Qualification> Qualifications { get; set; }
        public List<Skill> Skills { get; set; }
        public int Experience { get; set; }
        public int NoOfVaccancy { get; set; }
        public string Detail { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
