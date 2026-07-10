using GameEngine.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameTest.Menus
{
    public class MianMenu
    {
        
        enum Startmenu
        {
            CreatePlayer = 1,
            InformationPlayer = 2,
            Exit = 3
        }
        
        public void Start()
        {
            Console.WriteLine("====================");
            Console.WriteLine("========GAME========");
            Console.WriteLine("====================");
            Console.WriteLine($"1.{Startmenu.CreatePlayer}");
            Console.WriteLine($"2.{Startmenu.InformationPlayer}");
            Console.WriteLine($"3.{Startmenu.Exit}");
            Console.WriteLine("Enter Row:");
            int Input = Convert.ToInt32(Console.ReadLine());

            Player? p1 = null;
            switch (Input)
            {
                case 1:
                    Console.WriteLine("Enter Name Character:");
                    string NamePlayer = Console.ReadLine();
                    p1 = new(NamePlayer, 100, 1, 50);
                    Console.WriteLine(p1.InformationPlayer());
                    break;
                case 2:
                    Console.WriteLine(p1.InformationPlayer());
                    break;

            }
        }
    
    }
    
}

