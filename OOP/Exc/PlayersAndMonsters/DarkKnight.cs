﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersAndMonsters
{
    public class DarkKnight : Knight
    {
        public string Username { get; set; }

        public int Level { get; set; }
        public DarkKnight(string Username, int Level) : base(Username, Level)
        {

        }
        public override string ToString()
        {
            return ToString();
        }
    }
}
