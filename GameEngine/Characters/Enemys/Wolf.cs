using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine.Characters.Enemys
{
    public class Wolf : Enemy
    {
        public Wolf()
        {
            Name = "Wolf";
            Health = 100;
            Damage = 70;
        }
    }
}
