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


        public string InformationPlayer()
        {
            return $"Your name is :{Name},Health :{Health} ,Level:{Level} ,Gold:{Gold}";
        }




    }
    
}
