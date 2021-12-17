using Microsoft.EntityFrameworkCore;

namespace API_ASM1.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
    }

    class StudentDb : DbContext
    {
        public StudentDb(DbContextOptions<StudentDb> options)
            : base(options) { }

        public DbSet<Student> Students => Set<Student>();
    }
}
