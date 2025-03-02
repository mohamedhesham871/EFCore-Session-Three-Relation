using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Session_Three_Relation.Models
{
    internal class Department
    {
        public int ID { get; set; }
        public required string Name { get; set; }
        public DateOnly HiringDate { get; set; }

        #region Ins and Deparment Relation
        [InverseProperty(nameof(Instructor.department))]
        public ICollection<Instructor>? instructors {  get; set; }
        #endregion


        #region Ins and Deparment [manager]
        //Fk 
        [ForeignKey("manager")]
        public int managerId { get; set; }

        [InverseProperty(nameof(Instructor.ManagerOfDept))]
        public required Instructor? manager { get; set; }
        #endregion

        #region relation Between Student and Department
        [InverseProperty(nameof(Student.department))]
        public ICollection<Student> students { get; set; }
        #endregion
    }
}
