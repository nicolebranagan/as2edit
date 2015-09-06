using System;
using System.Collections.Generic;
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
        }

        public override string ToString()
        {
            if (type == ObjectType.key)
                return string.Concat("Key at X:", x.ToString(), ", Y:", y.ToString());
            else if (type == ObjectType.heart)
                return string.Concat("Heart at X:", x.ToString(), ", Y:", y.ToString());
            else if (type == ObjectType.goldkey)
                return string.Concat("Gold Key at X:", x.ToString(), ", Y:", y.ToString());
            else if (type == ObjectType.enemy)
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

        public StoredSpecial() { }

        public StoredSpecial(int row, int x, int y, int shootingrate, int speed, int amplitude, int time)
        {
            this.row = row;
            this.x = x;
            this.y = y;
            this.shootingrate = shootingrate;
            this.speed = speed;
            this.amplitude = amplitude;
            this.time = time;
        }
    }
}
