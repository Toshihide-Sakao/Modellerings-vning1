using System;

namespace ModelleringsÖvning1
{
    public class Map
    {
        public int[,] positions = new int[20, 40];

        public string[] sprites = {" ", "═", "║", "╔", "╗", "╚", "╝", "■", "σ","Θ", "░", "≈"}; 
        // tom rum, horizontal wall, vertical wall, leftTop, rightTop, leftBot, leftTop, box, char, enemy

    }
}
