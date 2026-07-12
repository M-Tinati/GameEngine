using GameEngine.Characters;
using GameEngine.Characters.Enemys;
using GameEngine.Inventory;
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
            InventoryPlayer = 4,
            Exit = 0
        }

        List<Player> players = new List<Player>();
        List<Enemy> enemy = new List<Enemy>();


        public void Start()
        {

            int Input = 0;
            enemy.Add(new Goblin());
            enemy.Add(new Wolf());
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
                    Console.WriteLine($"4.{Startmenu.InventoryPlayer}");
                    Console.WriteLine($"0.{Startmenu.Exit}");
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
                        case 3:

                            foreach (var i in enemy)
                            {
                                Console.WriteLine($"Enemy name is:{i.Name} ,Health:{i.Health} ,Level:{i.Damage}");
                            }
                            Console.WriteLine("With Which of the enemies want to fight the match?");
                            Console.WriteLine("Enter the name of the enemy");
                            string InputUserEnemy = Console.ReadLine().ToLower();
                            if (InputUserEnemy == "goblin")
                            {
                                Console.WriteLine("You choose Goblin");
                            }
                            else if (InputUserEnemy == "wolf")
                            {
                                Console.WriteLine("You choose Wolf");
                            }
                            break;
                        case 4:
                            Console.WriteLine("====================");
                            Console.WriteLine("=====Inventoryes====");
                            Console.WriteLine("====================");
                            ItemMenu Im = new ItemMenu();
                            Im.ItemMenus();
                            Im.InventoyesInformation();
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

