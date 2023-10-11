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
        protected readonly IConfiguration _configuration;
        public JpContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("ConnStr"));            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Job>().HasMany(e => e.Qualifications).WithOne(e => e.Job).HasForeignKey(e => e.QualificationRefID);
            modelBuilder.Entity<Job>().HasMany(e => e.Skills).WithOne(e => e.Job).HasForeignKey(e => e.SkillRefID);
            modelBuilder.Entity<JobSeeker>().HasMany(e => e.Qualifications).WithOne(e => e.JobSeeker).HasForeignKey(e => e.QualificationRefID);
            modelBuilder.Entity<JobSeeker>().HasMany(e => e.Skills).WithOne(e => e.JobSeeker).HasForeignKey(e => e.SkillRefID);
            modelBuilder.Entity<JobSeeker>().HasMany(e => e.JobSeekerCVs).WithOne(e => e.JobSeeker).HasForeignKey(e => e.SeekerRefID);
        }

        public DbSet<Employer> Employers { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobSeeker> JobSeekers { get; set; }
        public DbSet<JobSeekerCV> JobSeekerCVs { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
        public DbSet<Skill> Skills { get; set; }
    }
}
