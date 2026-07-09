using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine
{
    public class Player
    {
        
        public string Name { get; set; }
        public int Health { get; }
        public int Damage { get; set; }
        public int Level { get; }
        public int Gold { get; set; }


        public Player(string name)
        {
            this.Name = name;
            this.Health = 100;
            this.Level = 1;
            this.Gold = 50;
        }


        public void p()
        {
            Console.WriteLine($"{Name},{Health},{Level},{Gold}");
        }




    }
    
}
