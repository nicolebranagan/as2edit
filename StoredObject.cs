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

        public enum ObjectType
        {
            key = 0,
            heart = 1,
            goldkey = 2,
            enemy = 3,
            shooter = 4,
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
            else
                return base.ToString();
        }
    }
}
