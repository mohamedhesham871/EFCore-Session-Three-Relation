using System;
using System.Collections.Generic;
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
        //Dept_ID
    }
}
