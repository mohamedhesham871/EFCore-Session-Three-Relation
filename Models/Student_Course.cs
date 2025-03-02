using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Session_Three_Relation.Models
{
    internal class Student_Course
    {
        [ForeignKey("Student")]
        public int StudentId { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }

        [InverseProperty(nameof(Models.Student.student_Course))]
        public  required Student Student { get; set; }

        [InverseProperty(nameof(Models.Course.student_Course))]
        public required Course Course { get; set; }

        public int Grade { get; set; }
    }
}
