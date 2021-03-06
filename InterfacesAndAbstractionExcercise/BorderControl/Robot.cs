﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl.Contracts
{
    public class Robot : ICreature
    {
        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }

        public string Model { get; set; }
        public string Id { get; set; }
    }
}
