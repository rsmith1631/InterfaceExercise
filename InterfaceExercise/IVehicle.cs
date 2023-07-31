﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public string Name { get; set; }
        public int Wheels { get; set; }
        public int Seats { get; set; }
        public string DoorOpen { get; set; }
        public void TurnKey();
        public void Reverse();
    }
}
