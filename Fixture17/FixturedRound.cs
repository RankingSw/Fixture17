using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Fixture17
{
    /// <summary>
    /// Encapsulates a Round of the fixture
    /// </summary>
    /// <param name="Saturday">
    /// Specifically for Rounds in the 2020 season, using Excel date numbering
    /// </param>
    public class FixturedRound
    {
        public List<FixturedMatch> Matches { get; private set; }
        public int RoundNumber { get; set; }
        public DateTime Saturday { get { return DateTime.FromOADate(43981.5 + 7.0 * RoundNumber); } }

        public FixturedRound(int roundNumber)
        {
            RoundNumber = roundNumber;
            Matches = new List<FixturedMatch>();
        }

        /// <summary>
        /// Fisher-Yates shuffle
        /// In the commented-out code, see examples of Locked matches that must happen in that Round
        /// The teams remaining in 'array' can be randomised
        /// </summary>
        public static FixturedRound RandomRound(int roundNumber)
        {
            FixturedRound r = new FixturedRound(roundNumber);
            Random rng = new Random();
            int n = 18;
            int[] array = new int[n];

            //if (roundNumber >= 7 && roundNumber <= 9)
            //{
            //    n = 14;
            //    array = new int[14] { 0, 1, 2, 4, 7, 8, 9, 10, 11, 12, 13, 14, 15, 17 };
            //    if (roundNumber == 7)
            //    {
            //        r.Matches.Add(new FixturedMatch(r, Matchup.FindMatchup(5, 16), true, true));
            //        r.Matches.Add(new FixturedMatch(r, Matchup.FindMatchup(3, 6), true, true));
            //    }
            //    else if (roundNumber == 8)
            //    {
            //        r.Matches.Add(new FixturedMatch(r, Matchup.FindMatchup(5, 6), true, true));
            //        r.Matches.Add(new FixturedMatch(r, Matchup.FindMatchup(3, 16), false, true));
            //    }
            //    else if (roundNumber == 9)
            //    {
            //        r.Matches.Add(new FixturedMatch(r, Matchup.FindMatchup(6, 16), false, true));
            //        r.Matches.Add(new FixturedMatch(r, Matchup.FindMatchup(3, 5), false, true));
            //    }
            //}
            //if (roundNumber == 9)
            //{
            //    n = 12;
            //    array = new int[12] { 0, 1, 4, 7, 8, 10, 11, 12, 13, 14, 15, 17 };
            //    r.Matches.Add(new FixturedMatch(r, Matchup.FindMatchup(6, 16), false, true));
            //    r.Matches.Add(new FixturedMatch(r, Matchup.FindMatchup(3, 5), false, true));
            //    r.Matches.Add(new FixturedMatch(r, Matchup.FindMatchup(2, 9), false, true));
            //}
            //else if (roundNumber == 10)
            //{
            //    n = 14;
            //    array = new int[14] { 0, 1, 3, 4, 6, 7, 8, 10, 11, 12, 13, 14, 15, 17 };
            //    r.Matches.Add(new FixturedMatch(r, Matchup.FindMatchup(2, 5), false, true));
            //    r.Matches.Add(new FixturedMatch(r, Matchup.FindMatchup(9, 16), false, true));
            //}
            //else if (roundNumber == 11)
            //{
            //    n = 14;
            //    array = new int[14] { 0, 1, 3, 4, 6, 7, 8, 10, 11, 12, 13, 14, 15, 17 };
            //    r.Matches.Add(new FixturedMatch(r, Matchup.FindMatchup(2, 16), false, true));
            //    r.Matches.Add(new FixturedMatch(r, Matchup.FindMatchup(5, 9), true, true));
            //}
            //if (roundNumber == 13)
            //{
            //    n = 12;
            //    array = new int[12] { 0, 1, 2, 3, 6, 7, 9, 10, 11, 12, 14, 17 };
            //    r.Matches.Add(new FixturedMatch(r, Matchup.FindMatchup(4, 13), true, true));
            //    r.Matches.Add(new FixturedMatch(r, Matchup.FindMatchup(5, 15), true, true));
            //    r.Matches.Add(new FixturedMatch(r, Matchup.FindMatchup(8, 16), false, true));
            //}
            if (roundNumber == 14)
            {
                n = 14;
                array = new int[14] { 1, 2, 3, 4, 6, 7, 10, 11, 12, 13, 14, 15, 16, 17 };
                r.Matches.Add(new FixturedMatch(r, Matchup.FindMatchup(5, 8), false, true));
                r.Matches.Add(new FixturedMatch(r, Matchup.FindMatchup(0, 9), false, true));
            }
            else
            {
                for (int i = 0; i < n; i++)
                    array[i] = i;
            }
            for (int i = 0; i < n - 1; i++)
            {
                // Use Next on random instance with an argument.
                // ... The argument is an exclusive bound.
                //     So we will not go past the end of the array.
                int rand = i + rng.Next(n - i);
                int temp = array[rand];
                array[rand] = array[i];
                array[i] = temp;
            }

            // Enforce the Matchup order with lower index first
            for (int j = 0; j < n; j += 2)
            {
                if (array[j] > array[j + 1])
                    r.Matches.Add(new FixturedMatch(r, Matchup.FindMatchup(array[j + 1], array[j]), j % 4 == 0, false));
                else
                    r.Matches.Add(new FixturedMatch(r, Matchup.FindMatchup(array[j], array[j + 1]), j % 4 == 0, false));
            }


            return r;
        }

        public void AddMatch(int i1, int i2, bool isHome, int? exactDate = null)
        {
            System.Diagnostics.Debug.Assert(i1 < i2);
            FixturedMatch fm = new FixturedMatch(this, Matchup.FindMatchup(i1, i2), isHome, false, exactDate);
            Matches.Add(fm);
        }

        public void AddLockedMatch(int i1, int i2, bool isHome, int? exactDate = null)
        {
            System.Diagnostics.Debug.Assert(i1 < i2);
            FixturedMatch fm = new FixturedMatch(this, Matchup.FindMatchup(i1, i2), isHome, true, exactDate);
            Matches.Add(fm);
        }

        public override string ToString()
        {
            string s = "Round " + RoundNumber.ToString() + ":";
            foreach (FixturedMatch fm in Matches)
                s += "  " + fm.ToString();
            return s;
        }

        public string ToCSV()
        {
            string s = "";
            foreach (FixturedMatch fm in Matches)
                s += fm.ToCSV() + System.Environment.NewLine;
            return s;
        }
    }
}
