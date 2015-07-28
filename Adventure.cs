using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace as2edit
{
    public class Adventure
    {
        public int tileset;
        public int[] key = { };
        public Room[,] rooms = new Room[16, 16];
        public Room templateRoom = new Room();
    }
}
