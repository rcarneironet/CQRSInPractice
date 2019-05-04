using System;
using CQRS.Logic.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CQRS.Logic.DataAccess
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<GradeEnrollment> GradeEnrollments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Student>(ConfigureStudents);
            builder.Entity<Grade>(ConfigureGrades);
            builder.Entity<GradeEnrollment>(ConfigureGradeEnrollment);
        }

        private void ConfigureGradeEnrollment(EntityTypeBuilder<GradeEnrollment> builder)
        {
            builder.ToTable("GradesEnrollments");

            builder.HasKey(x => x.StudentId);
            builder.HasKey(x => x.GradeId);
        }

        private void ConfigureGrades(EntityTypeBuilder<Grade> builder)
        {
            builder.ToTable("Grades");

            builder.HasKey(x => x.ID);
            builder.Property(x => x.Name).IsRequired();
        }

        private void ConfigureStudents(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students");
            builder.HasKey(x => x.ID);

            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Age).IsRequired();
            builder.Property(x => x.Address).IsRequired();

        }
    }
}
