﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace as2edit
{
    public class StoredObject
    {
        public float x, y;
        public ObjectType type;
        public int enemyType;
        public EntityData data;

        public int dest, destx, desty, destroomX, destroomY;
        public int screen, key;

        public enum ObjectType
        {
            key = 0,
            heart = 1,
            goldkey = 2,
            enemy = 3,
            shooter = 4,
            boss = 5,
            entity = 6,
            teleporter = 7,
            stock = 8,
            special = 9,
            hidden = 10,
        }

        public Color getColor()
        {
            switch (type)
            {
                case ObjectType.key:
                    return Color.Gray;
                case ObjectType.heart:
                    return Color.DarkRed;
                case ObjectType.goldkey:
                    return Color.Gold;
                case ObjectType.enemy:
                    return Color.Red;
                case ObjectType.shooter:
                    return Color.Magenta;
                case ObjectType.boss:
                    return Color.Pink;
                case ObjectType.entity:
                    return Color.White;
                case ObjectType.teleporter:
                    return Color.Green;
                case ObjectType.stock:
                    return Color.LightCyan;
                case ObjectType.special:
                    return Color.DarkGreen;
                case ObjectType.hidden:
                    return Color.Red;
                default:
                    return Color.Black;
            }
        }

        public override string ToString()
        {
            if (type == ObjectType.key)
                return string.Concat("Key at X:", x.ToString(), ", Y:", y.ToString());
            else if (type == ObjectType.heart)
                return string.Concat("Heart at X:", x.ToString(), ", Y:", y.ToString());
            else if (type == ObjectType.goldkey)
                return string.Concat("Gold Key at X:", x.ToString(), ", Y:", y.ToString());
            else if (type == ObjectType.enemy || type == ObjectType.hidden)
                return string.Concat(Main.currentFile.bestiary[enemyType], " at X:", x.ToString(), ", Y:", y.ToString());
            else if (type == ObjectType.shooter)
                return string.Concat("Shooter at X:", x.ToString(), ", Y:", y.ToString());
            else if (type == ObjectType.boss)
                return string.Concat("Boss at X:", x.ToString(), ", Y:", y.ToString());
            else if (type == ObjectType.entity)
                return string.Concat("Entity ", data.name, " at X:", x.ToString(), ", Y:", y.ToString());
            else if (type == ObjectType.teleporter)
                return string.Concat("Teleporter at X:", x.ToString(), ", Y:", y.ToString());
            else if (type == ObjectType.stock)
                return string.Concat("Stock Entity ", Main.currentFile.stockEntities[enemyType].name, " at X:", x.ToString(), ", Y:", y.ToString());
            else if (type == ObjectType.special)
                if (key == 0)
                    return string.Concat("Warp to Special Stage ", screen.ToString(), " at X:", x.ToString(), ", Y:", y.ToString());
                else
                    return string.Concat("Warp to Special Stage ", screen.ToString(), " with Key ", key.ToString(), " at X:", x.ToString(), ", Y:", y.ToString());
            else
                return base.ToString();
        }
    }

    public struct EntityData
    {
        public string name;
        public string code;
        public int graphics;
        public GraphicsType gfxtype;

        public enum GraphicsType
        {
            Maptile = 0,
            Enemies = 1,
            Characters = 2,
            Null = 3,
        }
    }

    public class StoredSpecial
    {
        public int row, x, y, shootingrate, behavior, speed, amplitude, time;
        public bool track;

        public StoredSpecial() { }

        public StoredSpecial(int row, int x, int y, int shootingrate, int speed, int amplitude, int time, int behavior, bool track)
        {
            this.row = row;
            this.x = x;
            this.y = y;
            this.shootingrate = shootingrate;
            this.speed = speed;
            this.amplitude = amplitude;
            this.time = time;
            this.behavior = behavior;
            this.track = track;
        }

        public StoredSpecial Clone()
        {
            StoredSpecial sS = new StoredSpecial();
            sS.row = row;
            sS.x = x;
            sS.y = y;
            sS.shootingrate = shootingrate;
            sS.behavior = behavior;
            sS.speed = speed;
            sS.amplitude = amplitude;
            sS.time = time;
            sS.track = track;
            return sS;
        }
    }
}
