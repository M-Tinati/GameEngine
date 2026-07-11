using GameEngine.Characters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace GameTest.Menus
{
    public class MianMenu
    {

        enum Startmenu
        {
            CreatePlayer = 1,
            InformationPlayer = 2,
            Enemy = 3,
            Exit = 4
        }

        List<Player> players = new List<Player>();

        public void Start()
        {

            int Input = 0;
            while (Input != 4)
            {
                try
                {
                    Console.WriteLine("====================");
                    Console.WriteLine("========GAME========");
                    Console.WriteLine("====================");
                    Console.WriteLine($"1.{Startmenu.CreatePlayer}");
                    Console.WriteLine($"2.{Startmenu.InformationPlayer}");
                    Console.WriteLine($"3.{Startmenu.Enemy}");
                    Console.WriteLine($"4.{Startmenu.Exit}");
                    Console.WriteLine("Enter Row:");
                    Input = Convert.ToInt32(Console.ReadLine());
                    switch (Input)
                    {
                        case 1:
                            Console.WriteLine("Enter Name Character:");
                            string NamePlayer = Console.ReadLine();
                            players.Add(new Player(NamePlayer, 100, 1, 50));
                            Console.WriteLine("Your character created");
                            break;
                        case 2:
                            if (players.Count != 0)
                            {
                                foreach (Player p in players)
                                {
                                    Console.WriteLine($"Your name is:{p.Name} ,Health:{p.Health} ,Level:{p.Level} ,Gold:{p.Gold}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("not have player yet!!!!");
                            }
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("please just number");
                }
            }
            Console.WriteLine("exit");
        }












    }
}

