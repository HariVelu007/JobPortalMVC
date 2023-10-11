using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModel
{
    public class Employer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public string ContactPerson { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Mobile { get; set; }
        public string Detail { get; set; }
        public string Type { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public string Logo { get; set; }
        public int Status { get; set; }
    }
}