using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace as2edit
{
    public class Map
    {
        public const int width = 100;
        public const int height = 100;

        public int[] tileMap = new int[width*height];
        public int[] key = { 0 };

        public Map Clone()
        {
            Map newMap = new Map();
            this.tileMap.CopyTo(newMap.tileMap, 0);
            newMap.key = new int[this.key.Length];
            this.key.CopyTo(newMap.key, 0);
            return newMap;
        }
    }
}
