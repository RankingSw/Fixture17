using System;
using System.Collections.Generic;
using System.Text;

namespace Fixture17
{
    
    /// <summary>
    /// Class encapsulating possible Matchups between each pair of clubs, and a static List to hold them all in order
    /// Enforces i < j
    /// </summary>
    /// <param name="Key">
    /// Flattening of club index pair into a single index
    /// </param>
    public class Matchup
    {
        public static List<Matchup> AllMatchups { get; private set; }
        public int Index1 { get; set; }
        public int Index2 { get; set; }
        public int Key { get { return Index1 * (33 - Index1) / 2 + Index2 - 1; } }

        public Club Club1 { get { return Club.Clubs[Index1]; } }
        public Club Club2 { get { return Club.Clubs[Index2]; } }
        public string Club1Abbr { get { return Club1.Abbrev; } }
        public string Club2Abbr { get { return Club2.Abbrev; } }

        public static void Initialise()
        {
            AllMatchups = new List<Matchup>(153);
            for (int i = 0; i < 17; i++)
            {
                for (int j = i + 1; j < 18; j++)
                    AllMatchups.Add(new Matchup() { Index1 = i, Index2 = j });
            }
        }

        public static Matchup FindMatchup(int i1, int i2)
        {
            Matchup test;
            if (i1 < i2)
                test = new Matchup() { Index1 = i1, Index2 = i2 };
            else
                test = new Matchup() { Index1 = i2, Index2 = i1 };
            return AllMatchups[test.Key];
        }

        public bool Contains(int clubIndex)
        {
            return Index1 == clubIndex || Index2 == clubIndex;
        }

        public override string ToString()
        {
            return Club1Abbr + "-" + Club2Abbr;
        }

        public string ToString(bool isHome)
        {
            if (isHome)
                return Club1Abbr + " v " + Club2Abbr;
            else
                return Club2Abbr + " v " + Club1Abbr;
        }
    }
}
