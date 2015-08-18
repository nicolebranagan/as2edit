﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace as2edit
{
    public class BestiaryEntry
    {
        public string name = "";
        public int graphicsRow = 0;
        public int speed = 0;
        public int decisiveness = 0;
        public int intelligence = 0;
        public int health = 1;
        public MovementTypes movementType = MovementTypes.stationary;

        public enum MovementTypes
        {
            stationary = 0,
            random = 1,
            intelligent= 2
        }

        public override string ToString()
        {
            return name;
        }
    }
}
