using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine.Characters
{
    public class Enemy
    {
        private string _name;
        public int Health;
        public int Damage;

        /// <summary>
        /// Health not should less than zero
        /// zero == dead
        /// </summary>

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
