﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleLib
{
    public class Unit
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public bool Alive { get; set; }
        public List<BattleSkill> Skills { get; set; }

        public Unit()
        {
            Skills = new List<BattleSkill>();
            Skills.Add(new BattleSkill("KILL"));
        }
    }
}
