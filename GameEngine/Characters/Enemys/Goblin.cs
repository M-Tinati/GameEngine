using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine.Characters.Enemys
{
    public class Goblin : Enemy
    {
        public Goblin()
        {
            Name = "Goblin";
            Health = 100;
            Damage = 40;
        }
    }
}
