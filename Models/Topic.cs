using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Session_Three_Relation.Models
{
    internal class Topic
    {
        public int ID { get; set; }
        public  required string Name { get; set; }

        #region Topic has many courses

        public ICollection<Course>? Course { get; set; }
        #endregion

    }
}
