using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPlatform.DataAccess.Postgres.Models
{
    public class StudentEntity
    {
        public Guid Id { get; set; }

        public string UserName { get; set; } = string.Empty;

        public List<CourseEntity> Courses { get; set; } = new();
    }
}
