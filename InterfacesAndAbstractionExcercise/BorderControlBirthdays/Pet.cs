﻿using BorderControlBirthdays.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControlBirthdays
{
    public class Pet : IBirthdayable
    {
        public Pet(string name, string birthday)
        {
            Name = name;
            Birthday = birthday;
        }

        public string Name { get; set; }
        public string Birthday { get; set; }
    }
}
