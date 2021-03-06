﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace as2edit
{
    public class Room
    {
        public int[] tileMap = new int[25*13];
        public List<StoredObject> storedObjects = new List<StoredObject>();
        public string code;
        public bool dark = false;
        public bool hblock = false;
        public bool vblock = false;
        public int music = -1;
        
        public Room copyRoom()
        {
            Room newRoom = new Room();
            this.tileMap.CopyTo(newRoom.tileMap, 0);
            return newRoom;
        }
    }
}
