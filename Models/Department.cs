﻿using System;
using System.Collections.Generic;
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

    }
}
