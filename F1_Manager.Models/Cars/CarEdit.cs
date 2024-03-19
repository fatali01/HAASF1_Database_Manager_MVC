﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Manager.Models.Cars
{
    public class CarEdit
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string Engine { get; set; }
        public int HorsePower { get; set; }
        public double Acceleration { get; set; }
        public double TopSpeed { get; set; }
        public double Weight { get; set; }
    }
}
