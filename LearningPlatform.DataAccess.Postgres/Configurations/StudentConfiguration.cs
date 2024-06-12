using LearningPlatform.DataAccess.Postgres.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPlatform.DataAccess.Postgres.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<StudentEntity>
    {
        public void Configure(EntityTypeBuilder<StudentEntity> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasMany(s => s.Courses)
                .WithMany(c => c.Students);
        }
    }
}
