using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public int Course { get; set; }
        public virtual Group Group { get; set; }
    }
}
