using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp
{
    public class Teacher
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public float Experience { get; set; }
        public string Grade { get; set; }
        public List<Group> Groups { get; set; }
        public List<Subject> Subjects { get; set; }

        public Teacher()
        {
            Groups = new List<Group>();
            Subjects = new List<Subject>();
        }
    }
}
