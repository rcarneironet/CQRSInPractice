using CQRSInPractice.Application.Departamentos.Secretaria.Alunos.Commands;
using CQRSInPractice.Application.Departamentos.Secretaria.Alunos.Queries;
using CQRSInPractice.Application.Interfaces;
using CQRSInPractice.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace CQRSInPractice.Infrastructure
{
    public class CqrsDbContext : DbContext, ICqrsDbContext
    {
        public CqrsDbContext(DbContextOptions<CqrsDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(configureStudent);
        }

        private void configureStudent(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.Age)
            .IsRequired();

            builder.Property(x => x.Address)
                .IsRequired()
                .HasMaxLength(50);
        }

        public AlunoViewModel ObterAlunoPorNome(ObterAlunoPorNomeQuery query)
        {
            var student = new Student()
            {
                Name = query.Nome
            };

            try
            {
                var model =
                    Student.AsNoTracking()
                    .Where(x => x.Name == student.Name).FirstOrDefault();

                return new AlunoViewModel()
                {
                    Nome = model.Name
                };
            }
            catch (Exception)
            {
                //TODO: implemente uma forma melhor de logar suas exceptions :P
                throw;
            }
        }

        public bool RegistrarNovoAluno(RegistrarNovoAlunoCommand command)
        {
            var parameters = new List<SqlParameter>()
            {
                new SqlParameter("@Name", command.Nome),
                new SqlParameter("@Age", command.Idade),
                new SqlParameter("@Address", command.Endereco)
            };

            try
            {
                var result = Database
                    .ExecuteSqlCommand("EXEC PROCInsertStudent @Name, @Age, @Address",
                    parameters.ToArray());

                return result > 0;

            }
            catch (Exception)
            {
                //TODO: implemente uma forma melhor de logar suas exceptions :P
                throw;
            }
        }

        //public bool RegistrarNovoAluno(RegistrarNovoAlunoCommand command)
        //{
        //    try
        //    {
        //        var student = new Student()
        //        {
        //            Name = command.Nome,
        //            Age = command.Idade,
        //            Address = command.Endereco
        //        };

        //        Student.AddAsync(student);

        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        //TODO: implemente uma forma melhor de logar suas exceptions :P
        //        throw;
        //    }
        //}
    }
}
