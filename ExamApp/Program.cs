using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new SchoolContext())
            {
                Console.WriteLine("Start");

                Schedule schedule = new Schedule
                {
                    Id = Guid.NewGuid(),
                    Group = context.Groups.FirstOrDefault(),
                    Teacher = context.Teachers.FirstOrDefault(),
                    Subject = context.Subjects.FirstOrDefault(),
                    Time = new DateTime(2018, 04, 24, 9, 0, 0)
                };

                context.Schedules.Add(schedule);
                context.SaveChanges();

                Console.WriteLine("Schedule created!");
                Console.ReadLine();
            }
        }
    }
}
