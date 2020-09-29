using System;

namespace ModelleringsÖvning1
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map();
            Player player = new Player();
            Items items = new Items();

            Map grassland = new Map();

            player.x = 10;
            player.y = 8;
            player.weapon = items.Weapons[0];
            
            
            Console.ReadLine();
            StartGame(player, grassland);

            while (true)
            {
                Game(player, grassland);
            }
        }

        public static void StartGame(Player player, Map map)
        {
            MakeMap(map);
            WriteMap(map, player);
        }

        public static void Game(Player player, Map map) 
        {
            Move(player, map);
        }

        public static void MakeMap(Map map) 
        {
            int maxX = map.positions.GetLength(0) -1;
            int maxY = map.positions.GetLength(1) -1;

            for (int x = 0; x < maxX +1; x++)
            {
                for (int y = 0; y < maxY +1; y++)
                {
                    if (x == 0 && y == 0)
                    {
                        map.positions[x, y] = 3;
                    }
                    else if (x == 0 && y == maxY)
                    {
                        map.positions[x, y] = 4;
                    }
                    else if (x == maxX && y == 0)
                    {
                        map.positions[x, y] = 5;
                    }
                    else if (x == maxX && y == maxY)
                    {
                        map.positions[x, y] = 6;
                    }
                    else if (x == 0 || x ==  maxX)
                    {
                        map.positions[x, y] = 1;
                    }
                    else if (y == 0 || y == maxY)
                    {
                        map.positions[x, y] = 2;
                    }
                    else
                    {
                        map.positions[x, y] = 10;
                    }
                }
            }
        }

        public static void WriteMap(Map map, Player player) 
        {
            for (int x = 0; x < map.positions.GetLength(0); x++)
            {
                for (int y = 0; y < map.positions.GetLength(1); y++)
                {
                    int sprite = 8;
                    if (x != player.x || y != player.y)
                    {
                        sprite = map.positions[x, y];
                    }

                    Console.Write(map.sprites[sprite]);
                }
                Console.Write("\n");
            }
        }

        public static void RefreshPlayerFromRight(Map map, Player player)
        {
            
            map.positions[player.y, player.x] = 8;
            map.positions[player.oldX, player.oldY] = 10;
            Console.SetCursorPosition(player.x, player.y);
            Console.Write(map.sprites[10] + map.sprites[8]);
        }

        public static void Move(Player player, Map map) 
        {
            player.oldX = player.y;
            player.oldY = player.x; 

            ConsoleKeyInfo uInput = Console.ReadKey();
            if (uInput.Key == ConsoleKey.D && player.y < map.positions.GetLength(1) -2)
            {
                player.y++;
                RefreshPlayerFromRight(map, player);
            }
            if (uInput.Key == ConsoleKey.A && player.y > 1)
            {
                player.y--;
            }
            if (uInput.Key == ConsoleKey.S && player.x < map.positions.GetLength(0) -2)
            {
                player.x++;
            }
            if (uInput.Key == ConsoleKey.W && player.x > 1) 
            {
                player.x--;
                
            }
        }

            // public void WriteMap(int what) 
            // {
            //     for (int x = 0; x < 5; x++)
            //     {
            //         for (int y = 0; y < 5; y++)
            //         {
            //             int sprite = map.positions[x, y];

            //         }
            //     }
            // }
    }
}
