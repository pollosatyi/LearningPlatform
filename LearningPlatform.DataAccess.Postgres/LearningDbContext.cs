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
        public  DbSet<CourseEntity>Courses { get; set; }

        public DbSet<LessonEntity> Lessons { get; set; }

        public DbSet<AuthorEntity> Authors { get; set; }

        public DbSet<StudentEntity> Students { get; set; }
    }
}
