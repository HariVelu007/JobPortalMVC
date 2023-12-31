﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Skill
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int SkillRefID { get; set; }
        public string SkillName { get; set; }
        public Job Job { get; set; }
        public JobSeeker JobSeeker { get; set; }
    }
}
