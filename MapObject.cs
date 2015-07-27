using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace as2edit
{
    public abstract class MapObject
    {
        public int x, y;
    }

    public class MapTeleporter : MapObject
    {
        public int dest, destscreen, destx, desty; // if dest = -1, stay on map

        public MapTeleporter(int x, int y, int dest, int destscreen, int destx, int desty)
        {
            this.x = x;
            this.y = y;
            this.dest = dest;
            this.destscreen = destscreen;
            this.destx = destx;
            this.desty = desty;
        }
    }
}
