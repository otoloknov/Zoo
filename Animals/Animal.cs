﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Weight { get; set; }

        public abstract void Talk();
    }
}
