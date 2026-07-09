using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine
{
    internal class Enemy
    {
        public string Name { get; set; }
        public short Health { get; set; }
        public short Damage { get; set; }
        public int Level { get; set; }
        public int Gold { get; set; }
    }
}
