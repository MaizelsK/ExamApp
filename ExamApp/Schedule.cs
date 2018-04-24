using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp
{
    public class Schedule
    {
        public Guid Id { get; set; }
        public DateTime Time { get; set; }
        public Group Group { get; set; }
        public Teacher Teacher { get; set; }
        public Subject Subject { get; set; }
    }
}
