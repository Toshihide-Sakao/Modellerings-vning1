using System;

namespace ModelleringsÖvning1
{
    public class Map
    {
        public int[,] positions = new int[,]
        {
            {2, 1, 1, 1, 1, 1, 1, 1, 2},
            {2, 0, 0, 0, 0, 0, 0, 0, 2},
            {2, 0, 0, 0, 0, 0, 0, 0, 2},
            {2, 0, 0, 0, 0, 0, 0, 0, 2},
            {2, 1, 1, 1, 1, 1, 1, 1, 2}
        };

        public string[] sprites = {" ", "-", "|", "0"}; 


    }
}
