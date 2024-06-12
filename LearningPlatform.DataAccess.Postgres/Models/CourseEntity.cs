﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPlatform.DataAccess.Postgres.Models
{
    public class CourseEntity
    {
        public Guid Id { get; set; }

        public string Title { get; set; }=string.Empty;

        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; } = 0;
         
    }
}