using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine.Characters
{
    public class Player : Character
    {
        
        
        public int Gold { get; set; }


        public Player(string name,int health,int level, int gold)
        {
            Name = name;
            Health = health;    
            Level = level;
            Gold = gold;
        }


        public void InformationPlayer()
        {
            Console.WriteLine($"{Name},{Health},{Level},{Gold}");
        }




    }
    
}
