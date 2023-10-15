using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace PoratlServices.Config
{
    public class JpContext : DbContext
    {        
        public JpContext(DbContextOptions<JpContext> db) : base(db)
        {
            
        }
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Job>().HasMany(e => e.Qualifications).WithOne(e => e.Job).HasForeignKey(e => e.QualificationRefID);
            modelBuilder.Entity<Job>().HasMany(e => e.Skills).WithOne(e => e.Job).HasForeignKey(e => e.SkillRefID);
            modelBuilder.Entity<JobSeeker>().HasMany(e => e.Qualifications).WithOne(e => e.JobSeeker).HasForeignKey(e => e.QualificationRefID);
            modelBuilder.Entity<JobSeeker>().HasMany(e => e.Skills).WithOne(e => e.JobSeeker).HasForeignKey(e => e.SkillRefID);
            modelBuilder.Entity<JobSeeker>().HasMany(e => e.JobSeekerCVs).WithOne(e => e.JobSeeker).HasForeignKey(e => e.SeekerRefID);
            modelBuilder.Entity<User>().HasOne(e => e.Employer).WithOne(e => e.User).HasForeignKey<Employer>(x => x.EMail).HasPrincipalKey<User>(z => z.EMail);
            modelBuilder.Entity<User>().HasOne(e => e.JobSeeker).WithOne(e => e.User).HasForeignKey<JobSeeker>(x => x.EMail).HasPrincipalKey<User>(z=>z.EMail);
        }

        public DbSet<Employer> Employers { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobSeeker> JobSeekers { get; set; }
        public DbSet<JobSeekerCV> JobSeekerCVs { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
