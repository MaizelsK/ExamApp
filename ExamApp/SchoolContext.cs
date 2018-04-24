using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("SchoolDb")
        {
            Database.SetInitializer(new SchoolInitializer());
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
    }

    public class SchoolInitializer : CreateDatabaseIfNotExists<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            List<Student> students = new List<Student>
            {
                new Student { FullName="Kirill Maizels", Course = 1, Id = Guid.NewGuid()},
                new Student { FullName="Nikita Nikitov", Course = 1, Id = Guid.NewGuid()},
                new Student { FullName="Artem Artemov", Course = 1, Id = Guid.NewGuid()},
            };

            Group group = new Group { Name = "SMP-171", Course = 1, Id = Guid.NewGuid() };
            group.Students.AddRange(students);

            Subject subject = new Subject { Name = "С++", Id = Guid.NewGuid() };
            Teacher teacher = new Teacher { Name = "Andrey Andreevich", Experience = 10, Grade = "Professor", Id = Guid.NewGuid() };
            teacher.Groups.Add(group); teacher.Subjects.Add(subject);
            subject.Teacher = teacher;

            context.Students.AddRange(students);
            context.Teachers.Add(teacher);
            context.Groups.Add(group);
            context.Subjects.Add(subject);

            base.Seed(context);
        }
    }
}
