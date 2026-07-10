using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine.Characters
{
    public class Player : Character
    {
        
        
        public int Gold { get; set; }


        public Player(string name)
        {
            this.Name = name;
            Health = 100;
            Level = 1;
            Gold = 50;
        }


        public void p()
        {
            Console.WriteLine($"{Name},{Health},{Level},{Gold}");
        }




    }
    
}
