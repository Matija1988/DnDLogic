﻿using DnDLogic.Models.Special;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.Models.PlayableClasses
{
    public interface IPlayableClass
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public List<Ability> Abilities { get; set; }
    }
}
