using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace as2edit
{
    public class Adventure
    {
        public int tileset;
        public int[] key = { };
        public Room templateRoom = new Room();
        public string name = "";
        
        [XmlIgnore]
        public Room[,] rooms = new Room[16, 16];

        // XmlSerializer does not support multidimensional arrays, this is the next best thing
        public Room[] xmlRooms
        {
            get
            {
                Room[] xmlList = new Room[16 * 16];
                int x, y;
                for (int i = 0; i < (16*16); i++)
                {
                    x = i % 16;
                    y = i / 16;
                    xmlList[i] = rooms[x, y];
                }
                return xmlList;
            }

            set
            {
                int x, y;
                for (int i = 0; i < (16 * 16); i++)
                {
                    x = i % 16;
                    y = i / 16;
                    if (value[i] != null)
                        rooms[x,y] = value[i];
                }
            }
        }
    }
}
