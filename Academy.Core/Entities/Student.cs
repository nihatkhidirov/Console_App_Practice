﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Core.Entities
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int GroupID { get; set; }

        public Group Group { get; set; }
    }
}
