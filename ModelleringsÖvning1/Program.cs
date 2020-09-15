using System;

namespace ModelleringsÖvning1
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map();

        }

        public void WriteMap(int what, Map map) 
        {
            

            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    int sprite = map.positions[x, y];

                }
            }
        }

        public string(int what) 
        {
            switch (what)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
            }
        }
    }
}
