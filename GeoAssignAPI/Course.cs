using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GeoAssignAPI
{
    public class Course
    {
        public int CourseId { get; set; }
        public int CourseCode { get; set; }
        [Required]
        public string CourseName { get; set; }
    }
}
