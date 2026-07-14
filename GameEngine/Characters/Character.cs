using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace GameEngine.Characters
{
    public abstract class Character
    {
        private string _name;
        private int _health;
        private int _damge;
        private int _level;

        /// <summary>
        /// Health not should less than zero
        /// zero == dead
        /// </summary>
        /// 


       
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

        public int Health
        {
            get { return _health; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Your Health value less than 0 you dead?");
                }
                _health = value;
            }
        }

        public int Damage
        {
            get { return _damge; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Stop it You kill it");
                }
                _damge = value;
            }
        }

        public int Level
        {
            get { return _level; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Minimum Base Level is 1 ");
                }
                _level = value;
            }
        }
    }
}
