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

        public enum ObjectType
        {
            key = 0,
        }

        public override string ToString()
        {
            if (type == ObjectType.key)
                return String.Concat("Key at X:", x.ToString(), ", Y:", y.ToString());
            else
                return base.ToString();
        }
    }
}
