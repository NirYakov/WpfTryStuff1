﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtillsCalAvrg;

namespace WpfTryStuff1
{
    public class CourseItemViewModel
    {
        public string Name { get; set; }

        public ushort Mark { get; set; }

        public float Points { get; set; }

        public short Year { get; set; }

        public eSemester Semester { get; set; }
    }

    //public enum eSemester : ushort
    //{
    //    A  = 'A',
    //    B  = 'B',
    //    C = 'C'
    //}
}
