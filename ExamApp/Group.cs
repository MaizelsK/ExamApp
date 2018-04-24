using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp
{
    public class Group
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Course { get; set; }
        public virtual List<Student> Students { get; set; }

        public Group()
        {
            Students = new List<Student>();
        }
    }
}
