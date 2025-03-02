using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Session_Three_Relation.Models
{
    internal class Course
    {
        public int ID { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public int Duration { get; set; }
        //FK
        [ForeignKey("topic")]
        public int topicID { get; set; }
        #region Coures has one Topic

        public required Topic topic { get; set; }
        #endregion

        #region Relation Between Course and tabel Of Ins_course
        [InverseProperty(nameof(Course_instructor.Course))]
        public ICollection<Course_instructor>? course_Instructors { set; get; }
        #endregion

        #region Reltion m  to m table Student_Course
        [InverseProperty(nameof(Student_Course.Course))]
        public ICollection<Student_Course>? student_Course { set; get; }
        #endregion
    }

}
