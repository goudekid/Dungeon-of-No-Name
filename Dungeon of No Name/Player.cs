using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_of_No_Name
{
    public class Player
    {
        public int MaxHealth { get; set; }
        public int CurrHealth { get; set; }
        public int MaxExhaustion { get; set; }
        public int CurrExhaustion { get; set; }
        public Loc CurrLocation { get; set; }
        public int Attack { get; set; }
        public bool[] UnlockedAbilities { get; set; }  
        public char Facing { get; set; }           
        
        public Player(int startHp, int startExh, int startAtk, Loc startLoc)
        {
            MaxHealth = startHp;
            CurrHealth = startHp;
            MaxExhaustion = startExh;
            CurrExhaustion = startExh;
            CurrLocation = startLoc;
            Attack = startAtk;
        }
        
                       
    }

}
