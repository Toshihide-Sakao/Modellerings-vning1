using System;

namespace ModelleringsÖvning1
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map();
            Player player = new Player();

            player.x = 1;
            player.y = 1;

            WriteMap(map, player.x, player.y);
            Console.ReadLine();
        }

        public static void WriteMap(Map map, int playerX, int playerY) 
        {
            for (int x = 0; x < map.positions.GetLength(0); x++)
            {
                for (int y = 0; y < map.positions.GetLength(1); y++)
                {
                    int sprite = 3;
                    if (x != playerX || y != playerY)
                    {
                        sprite = map.positions[x, y];
                    }

                    Console.Write(map.sprites[sprite]);
                }
                Console.Write("\n");
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
