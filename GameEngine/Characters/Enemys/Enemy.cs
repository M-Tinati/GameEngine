using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine.Characters.Enemys
{
    public abstract class Enemy
    {
        private string _name;
        public int Health;
        public int Damage;

        /// <summary>
        /// Health not should less than zero
        /// zero == dead
        /// </summary>
        
        public virtual void Attack()
        {
            //pass
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Please Enter Your name !You can not empty this");
                }
                _name = value;
            }
        }
    }
}
