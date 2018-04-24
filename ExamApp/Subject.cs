using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp
{
    public class Subject
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Teacher Teacher { get; set; }
    }
}
