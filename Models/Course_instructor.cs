using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Session_Three_Relation.Models
{
    internal class Course_instructor
    {
        [ForeignKey("instructor")]
        public int InstructorId { get; set; }
        [ForeignKey("Course")]
        public int CourseId     { get; set; }
        //nav property

        [InverseProperty(nameof(Instructor.course_Instructors))]
        public required Instructor instructor { get; set; }

        [InverseProperty(nameof(Models.Course.course_Instructors))]
        public required Course Course { get; set; }

        public int evaluate {  get; set; }
    }
}
