using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolOnlineExamination.Models
{
    public class SchoolTestContext : IdentityDbContext
    {
        public SchoolTestContext(DbContextOptions<SchoolTestContext> options) : base(options)
        {

        }
        public DbSet<StudyMaterial> StudyMaterials { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Option> Options { get; set; }
    }
}
