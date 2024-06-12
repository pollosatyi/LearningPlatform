using LearningPlatform.DataAccess.Postgres.Configurations;
using LearningPlatform.DataAccess.Postgres.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPlatform.DataAccess.Postgres
{
    public class LearningDbContext : DbContext
    {
        public LearningDbContext(DbContextOptions<LearningDbContext> options) : base(options) { }
        public  DbSet<CourseEntity>Courses { get; set; }

        public DbSet<LessonEntity> Lessons { get; set; }

        public DbSet<AuthorEntity> Authors { get; set; }

        public DbSet<StudentEntity> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new LessonConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
