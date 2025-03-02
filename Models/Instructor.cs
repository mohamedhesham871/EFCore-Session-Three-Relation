using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Session_Three_Relation.Models
{
    internal class Instructor
    {
        public int ID { get; set; }
        public required string Name { get; set; }
        public decimal Salary { get; set; }
        public decimal? Bouns { get; set; }
        public string? Address { get; set; }
        public int? HoureRate { get; set; }


        #region Relation between Ins and Department [Work]
        //FK
        public int? departmentId { get; set; }

        [InverseProperty(nameof(Department.instructors))]
        public Department? department { get; set; }
        #endregion

        #region Relation between ins and deparment [manger]
        [InverseProperty(nameof(department.manager))]
        public Department? ManagerOfDept {  get; set; }
        #endregion

        #region Relation Between ins and tabel Of Ins_course
        [InverseProperty(nameof(Course_instructor.instructor))]
        public ICollection<Course_instructor>? course_Instructors { set; get; }
        #endregion
    }
}
