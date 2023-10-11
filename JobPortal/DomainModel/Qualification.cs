using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Qualification
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int QualificationRefID { get; set; }
        public string QualificationName { get; set; }
        public int CompletedOn { get; set; }
        public Job Job { get; set; }
        public JobSeeker JobSeeker { get; set; }
    }
}
