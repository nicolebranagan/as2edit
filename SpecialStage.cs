using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace as2edit
{
    public class SpecialStage
    {
        public int height;
        public int[] tileMap;
        public List<StoredSpecial> objects = new List<StoredSpecial>();
        public WinCondition winCondition = WinCondition.ReachEnd;

        public enum WinCondition
        {
            ReachEnd = 0,
            KillEnemies = 1,
        }
    }
}
