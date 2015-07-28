using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace as2edit
{
    [XmlInclude(typeof(MapTeleporter))]
    public abstract class MapObject
    {
        public int x, y;
    }

    public class MapTeleporter : MapObject
    {
        public int dest, destroomX, destroomY, destx, desty; // if dest = -1, stay on map

        public MapTeleporter()
        {; }

        public MapTeleporter(int x, int y, int dest, int destroomX, int destroomY, int destx, int desty)
        {
            this.x = x;
            this.y = y;
            this.dest = dest;
            this.destroomX = destroomX;
            this.destroomY = destroomY;
            this.destx = destx;
            this.desty = desty;
        }
    }
}
