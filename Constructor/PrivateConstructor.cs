﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Counter
    {
        private Counter()   //private constrctor declaration
        {
        }
        public static int currentview;
        public static int visitedCount()
        {
            return ++currentview;
        }
    }
}
