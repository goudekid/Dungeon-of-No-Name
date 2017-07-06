using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_of_No_Name
{
    public class Loc
    {
        public bool HasAttackableTarget { get; set; }
        public Monster Monster { get; set; }
        public bool HasNorthExit { get; set; }
        public bool HasEastExit { get; set; }
        public bool HasSouthExit { get; set; }
        public bool HasWestExit { get; set; }
        public int NumExits { get; set; }
        public int xCoord { get; set; }
        public int yCoord { get; set; }


        // basic constuctor for when we dont know x and y coords yet
        public Loc(Monster mon, bool n, bool e, bool s, bool w)
        {
            HasAttackableTarget = true;
            Monster = mon;
            HasNorthExit = n;
            HasEastExit = e;
            HasSouthExit = s;
            HasWestExit = w;
        }

        // no monster basic constructor
        public Loc(bool n, bool e, bool s, bool w)
        {
            HasAttackableTarget = false;
            HasNorthExit = n;
            HasEastExit = e;
            HasSouthExit = s;
            HasWestExit = w;
        }

        // constructor for when we gen a monster
        public Loc(Monster mon, bool n, bool e, bool s, bool w, int x, int y)
        {
            HasAttackableTarget = true;
            Monster = mon;
            HasNorthExit = n;
            HasEastExit = e;
            HasSouthExit = s;
            HasWestExit = w;
            xCoord = x;
            yCoord = y;
        }

        // for when we do not gen a monster
        public Loc(bool n, bool e, bool s, bool w, int x, int y)
        {
            HasAttackableTarget = false;
            HasNorthExit = n;
            HasEastExit = e;
            HasSouthExit = s;
            HasWestExit = w;
            xCoord = x;
            yCoord = y;
        }

        // gen first location basically
        public static Loc GenerateRandomLocation()
        {
            Random r = new Random();

            int exits = 0;

            bool[] randValues = new bool[5];

            for (int i = 0; i < 5; i++)
            {
                if (r.NextDouble() > 0.5)
                    randValues[i] = true;
                else
                    randValues[i] = false;
            }

            // if we just made a location with no exits at all
            // chose a side randomly and make it an exit
            if (randValues[1] == false &&
                randValues[2] == false &&
                randValues[3] == false &&
                randValues[4] == false)
            {
                randValues[r.Next(1, 5)] = true;
            }

            for (int i = 1; i < 5; i++)
            {
                if (randValues[i] == true)
                    exits++;
            }

            // index 0 is hasmonster = true
            if (randValues[0] == true)
            {
                //TODO: randomize monster gen
                Monster mon = new Monster("Grog", 100, 3);

                Loc newLoc = new Loc(mon, randValues[1], randValues[2], randValues[3], randValues[4]);

                newLoc.NumExits = exits;

                return newLoc;
            }
            else // if we didnt get a monster
            {
                Loc newLoc = new Loc(randValues[1], randValues[2], randValues[3], randValues[4]);
                newLoc.NumExits = exits;
                return newLoc;
            } 
        }

        // entrance side is the index of the side of the room we entered from that should 100% have an exit
        // 1 is n, 2 is e, 3 is s, 4 is w
        public static Loc GenerateRandomLocation(int entranceSide, int x, int y)
        {
            Random r = new Random();

            int exits = 0;

            bool[] randValues = new bool[5];

            for (int i = 0; i < 5; i++)
            {
                if (r.NextDouble() > 0.5)
                    randValues[i] = true;
                else
                    randValues[i] = false;
            }

            randValues[entranceSide] = true;


            // prevents out of bounds locations in our array (which is arbitrarily 10x10)
            if (x >= 9)
                randValues[2] = false;
            if (x <= 0)
                randValues[4] = false;
            if (y >= 9)
                randValues[1] = false;
            if (y <= 0)
                randValues[3] = false;


            for (int i = 1; i < 5; i++)
            {
                if (randValues[i] == true)
                    exits++;
            }

            // index 0 is hasmonster = true
            if (randValues[0] == true)
            {
                //TODO: randomize monster gen
                Monster mon = new Monster("Grog", 100, 3);

                Loc newLoc = new Loc(mon, randValues[1], randValues[2], randValues[3], randValues[4], x, y);
                newLoc.NumExits = exits;

                return newLoc;
            }
            else // if we didnt get a monster
            {
                Loc newLoc = new Loc(randValues[1], randValues[2], randValues[3], randValues[4], x, y);
                newLoc.NumExits = exits;
                return newLoc;
            }
        }

        public String ExitsAsString()
        {
            String n = "", s = "", e = "", w = "";

            if (this.HasEastExit == true)
            {
                e = ("There is an exit to the east." + System.Environment.NewLine);
            }
            if (this.HasNorthExit == true)
            {
                n = ("There is an exit to the north." + System.Environment.NewLine);
            }
            if (this.HasWestExit == true)
            {
                w = ("There is an exit to the west." + System.Environment.NewLine);
            }
            if (this.HasSouthExit == true)
            {
                s = ("There is an exit to the south." + System.Environment.NewLine);
            }

            return (n + s + e + w);

        }

    }
}
