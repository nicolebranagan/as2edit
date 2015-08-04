using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace as2edit
{
    public class Worldfile
    {
        public Map map = new Map();
        public List<Adventure> adventures = new List<Adventure>();
        public List<BestiaryEntry> bestiary = new List<BestiaryEntry>();
    }
}
