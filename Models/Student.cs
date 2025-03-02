using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Session_Three_Relation.Models
{
    internal class Student
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string? Address { get; set; }
        public required int Age { get; set; }


        #region Relation between Student And department [one to many]
        [ForeignKey("deparment")]
        public required int deparmentID { get; set; }

        [InverseProperty(nameof(Department.students))]
        public  required Department department { set; get; }
        #endregion
        #region Reltion m  to m table Student_Course
        [InverseProperty(nameof(Student_Course.Student))]
        public Student_Course ?student_Course { set; get; }
        #endregion
    }
}
