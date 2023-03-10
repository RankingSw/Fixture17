using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fixture17
{
    /// <summary>
    /// Most of the algorithmic logic sits in this class
    /// Final state of the Fixture class contains 13 complete rounds from 2020
    /// </summary>
    public class Fixture
    {
        public static FixturedRound Round1 { get; private set; }
        public static FixturedRound Round2 { get; private set; }
        public static FixturedRound Round3 { get; private set; }
        public static FixturedRound Round4 { get; private set; }
        public static FixturedRound Round5 { get; private set; }
        public static FixturedRound Round6 { get; private set; }
        public static FixturedRound Round7 { get; private set; }
        public static FixturedRound Round8 { get; private set; }
        public static FixturedRound Round9 { get; private set; }
        public static FixturedRound Round10 { get; private set; }
        public static FixturedRound Round11 { get; private set; }
        public static FixturedRound Round12 { get; private set; }
        public static FixturedRound Round13 { get; private set; }
        //public static FixturedRound Round14 { get; private set; }

        public static void Initialise()
        {
            Round1 = new FixturedRound(1);
            Round2 = new FixturedRound(2);
            Round3 = new FixturedRound(3);
            Round4 = new FixturedRound(4);
            Round5 = new FixturedRound(5);
            Round6 = new FixturedRound(6);
            Round7 = new FixturedRound(7);
            Round8 = new FixturedRound(8);
            Round9 = new FixturedRound(9);
            Round10 = new FixturedRound(10);
            Round11 = new FixturedRound(11);
            Round12 = new FixturedRound(12);
            Round13 = new FixturedRound(13);
            //Round14 = new FixturedRound(14);
            Round4.AddLockedMatch(0, 1, false, 44010); Round3.AddLockedMatch(0, 7, false, 44003); Round2.AddLockedMatch(0, 12, false, 43995); Round1.AddLockedMatch(0, 15, true, 43911);
            Round2.AddLockedMatch(1, 5, true, 43995); Round1.AddLockedMatch(1, 9, false, 43912); Round3.AddLockedMatch(1, 16, true, 44002);
            Round4.AddLockedMatch(2, 4, false, 44009); Round3.AddLockedMatch(2, 6, false, 44002); Round2.AddLockedMatch(2, 10, true, 43995); Round1.AddLockedMatch(2, 13, false, 43909);
            Round4.AddLockedMatch(3, 8, false, 44008); Round2.AddLockedMatch(3, 13, true, 43993); Round3.AddLockedMatch(3, 14, true, 44002); Round1.AddLockedMatch(3, 17, false, 43910);
            Round1.AddLockedMatch(4, 5, true, 43911);
            Round2.AddLockedMatch(4, 15, false, 43996);
            Round4.AddLockedMatch(5, 7, false, 44009); Round3.AddLockedMatch(5, 12, true, 44003);
            Round1.AddLockedMatch(6, 8, false, 43911); Round2.AddLockedMatch(6, 9, true, 43994); Round4.AddLockedMatch(6, 10, false, 44010);
            Round1.AddLockedMatch(7, 12, true, 43911); Round2.AddLockedMatch(7, 16, true, 43995);
            Round2.AddLockedMatch(8, 11, true, 43996); Round3.AddLockedMatch(8, 17, false, 44001);
            Round4.AddLockedMatch(9, 11, true, 44010); Round3.AddLockedMatch(9, 13, false, 44000);
            Round1.AddLockedMatch(10, 16, false, 43912);
            Round1.AddLockedMatch(11, 14, true, 43912); Round3.AddLockedMatch(11, 15, true, 44002);
            Round4.AddLockedMatch(12, 16, true, 44009);
            Round4.AddLockedMatch(13, 14, false, 44009);
            Round2.AddLockedMatch(14, 17, true, 43996);
            Round4.AddLockedMatch(15, 17, true, 44007);
            Round3.AddLockedMatch(4, 10, true, 44003);
            Round5.AddLockedMatch(2, 14, true, 44014);
            Round5.AddLockedMatch(3, 4, true, 44015);
            Round5.AddLockedMatch(15, 16, false, 44016);
            Round5.AddLockedMatch(6, 7, true, 44016);
            Round5.AddLockedMatch(11, 17, false, 44016);
            Round5.AddLockedMatch(1, 12, true, 44016);
            Round5.AddLockedMatch(0, 5, true, 44017);
            Round5.AddLockedMatch(10, 13, true, 44017);
            Round5.AddLockedMatch(8, 9, true, 44017);
            Round6.AddLockedMatch(1, 6, false, 44021); Round6.AddLockedMatch(3, 9, true, 44022);
            Round6.AddLockedMatch(5, 14, true, 44023); Round6.AddLockedMatch(0, 16, false, 44023);
            Round6.AddLockedMatch(7, 10, false, 44023); Round6.AddLockedMatch(4, 11, true, 44023);
            Round6.AddLockedMatch(8, 12, false, 44024); Round6.AddLockedMatch(13, 15, true, 44024); Round6.AddLockedMatch(2, 17, true, 44024);
            Round7.AddLockedMatch(3, 6, false, 44028); Round7.AddLockedMatch(4, 17, true, 44029);
            Round7.AddLockedMatch(1, 8, false, 44030); Round7.AddLockedMatch(7, 15, false, 44030);
            Round7.AddLockedMatch(11, 13, false, 44030);
            Round7.AddLockedMatch(2, 12, true, 44031); Round7.AddLockedMatch(9, 10, true, 44031); Round7.AddLockedMatch(5, 16, true, 44031);
            Round7.AddLockedMatch(0, 14, true, 44032);
            Round8.AddLockedMatch(7, 17, true, 44035); Round8.AddLockedMatch(8, 13, true, 44036);
            Round8.AddLockedMatch(2, 11, false, 44037); Round8.AddLockedMatch(9, 15, false, 44037); Round8.AddLockedMatch(12, 14, true, 44037);
            Round8.AddLockedMatch(0, 4, true, 44038); Round8.AddLockedMatch(3, 16, false, 44038); Round8.AddLockedMatch(1, 10, false, 44038);
            Round8.AddLockedMatch(5, 6, true, 44039);
            Round9.AddLockedMatch(13, 17, false, 44041);
            Round9.AddLockedMatch(2, 9, true, 44043); Round9.AddLockedMatch(10, 12, true, 44042);
            Round9.AddLockedMatch(1, 4, false, 44043);
            Round9.AddLockedMatch(0, 11, false, 44044); Round9.AddLockedMatch(14, 15, true, 44044); Round9.AddLockedMatch(6, 16, false, 44044);
            Round9.AddLockedMatch(7, 8, true, 44045); Round9.AddLockedMatch(3, 5, false, 44045);
            Round10.AddLockedMatch(12, 17, true, 44046);
            Round10.AddLockedMatch(1, 13, false, 44047);
            Round10.AddLockedMatch(6, 11, true, 44048); Round10.AddLockedMatch(0, 10, true, 44048);
            Round10.AddLockedMatch(3, 15, true, 44049); Round10.AddLockedMatch(7, 14, true, 44049);
            Round10.AddLockedMatch(4, 8, true, 44050);
            Round11.AddLockedMatch(12, 13, true, 44051); Round11.AddLockedMatch(1, 17, true, 44051);
            Round11.AddLockedMatch(2, 16, false, 44052); Round11.AddLockedMatch(10, 11, true, 44052);
            Round11.AddLockedMatch(6, 14, false, 44053); Round11.AddLockedMatch(5, 9, true, 44053);
            Round11.AddLockedMatch(0, 3, true, 44054);
            Round11.AddLockedMatch(4, 7, false, 44055);
            Round12.AddLockedMatch(8, 15, false, 44056);
            Round12.AddLockedMatch(6, 12, true, 44057);
            Round12.AddLockedMatch(1, 11, false, 44058); Round12.AddLockedMatch(3, 10, false, 44058); Round12.AddLockedMatch(2, 5, false, 44058);
            Round12.AddLockedMatch(0, 17, false, 44059); Round12.AddLockedMatch(4, 14, false, 44059); Round12.AddLockedMatch(9, 16, false, 44059);
            Round12.AddLockedMatch(7, 13, false, 44060);
            Round13.AddLockedMatch(2, 7, false, 44064);
            Round13.AddLockedMatch(10, 17, false, 44065); Round13.AddLockedMatch(9, 12, false, 44065);
            Round13.AddLockedMatch(4, 13, true, 44065); Round13.AddLockedMatch(5, 15, true, 44065);
            Round13.AddLockedMatch(0, 6, true, 44066); Round13.AddLockedMatch(1, 14, true, 44066); Round13.AddLockedMatch(8, 16, false, 44066);
            Round13.AddLockedMatch(3, 11, true, 44067);
            //Round14.AddLockedMatch(5, 8, true, 44072); Round14.AddLockedMatch(15, 16, true, 44072);
        }

        public List<FixturedRound> Rounds { get; private set; }
        private List<FixturedMatchupList> fixtured = null;
        public List<FixturedMatchupList> Fixtured {  get { return fixtured; } }
        public int NumberUnscheduled { get { { return fixtured.Count(f => f.Count == 0); } } }
        private Random rng = null;

        public Fixture(int numRounds)
        {
            Rounds = new List<FixturedRound>(numRounds);

            // Already scheduled or played: all games locked
            Rounds.Add(Round1);
            Rounds.Add(Round2);
            Rounds.Add(Round3);
            if (numRounds > 17)
                Round3.Matches.RemoveAt(8);
            Rounds.Add(Round4);
            Rounds.Add(Round5);
            Rounds.Add(Round6);
            Rounds.Add(Round7);
            Rounds.Add(Round8);
            Rounds.Add(Round9);
            Rounds.Add(Round10);
            Rounds.Add(Round11);
            Rounds.Add(Round12);
            Rounds.Add(Round13);

            // Random starters for remaining Rounds
            for (int i = 14; i <= numRounds; i++)
                Rounds.Add(FixturedRound.RandomRound(i));

            fixtured = new List<FixturedMatchupList>(153);
            for (int i = 0; i < 153; i++)
                fixtured.Add(new FixturedMatchupList(i));

            foreach (FixturedRound r in Rounds)
            {
                foreach (FixturedMatch fm in r.Matches)
                    fixtured[fm.Matchup.Key].Add(fm);
            }

            rng = new Random();
        }
        public int TimesFixtured(int key)
        {
            return fixtured[key].Count;
        }

        /// <summary>
        /// Stage One
        /// The core of the main algorithm: try to improve the pairings
        /// Keep running this until NumberUnscheduled is zero
        /// </summary>
        public void ImproveRandom()
        {
            // Find a round where a swap would make sense
            int max = fixtured.Max(l => l.Count);
            
            List<FixturedMatchupList> maxList = fixtured.Where(l => l.Count == max).ToList();
            FixturedMatch target = null;
            FixturedMatch swapper = null;
            while (target == null)
            {
                int rand1 = rng.Next(maxList.Count);
                int rand2 = rng.Next(max);
                target = maxList[rand1].Fixtured[rand2];
                // Is it already fixed in stone?
                if (target.IsLocked)
                {
                    target = null;
                    continue;
                }
                // Find another multi in the round
                swapper = null;
                int attempts = 0;
                while (swapper == null)
                {
                    attempts++;
                    int rand3 = rng.Next(9);
                    swapper = target.Round.Matches[rand3];
                    if (swapper == target || swapper.IsLocked)
                        swapper = null;
                    else if (fixtured[swapper.Matchup.Key].Count <= 1 && attempts < 20)
                        swapper = null;
                }
                if (swapper == null)
                {
                    target = null;
                    continue;
                }
                // Find the better swap
                Matchup mu1 = Matchup.FindMatchup(target.Matchup.Index1, swapper.Matchup.Index1);
                Matchup mu2 = Matchup.FindMatchup(target.Matchup.Index2, swapper.Matchup.Index2);
                Matchup mu3 = Matchup.FindMatchup(target.Matchup.Index1, swapper.Matchup.Index2);
                Matchup mu4 = Matchup.FindMatchup(target.Matchup.Index2, swapper.Matchup.Index1);
                FixturedMatch fm1, fm2;
                int comparison = fixtured[mu1.Key].Count + fixtured[mu2.Key].Count - (fixtured[mu3.Key].Count + fixtured[mu4.Key].Count);
                if (comparison > 0 || (comparison == 0 && rng.NextDouble() < 0.5))
                {
                    fm1 = new FixturedMatch(target.Round, mu3, rng.NextDouble() < 0.5, false);
                    fm2 = new FixturedMatch(target.Round, mu4, rng.NextDouble() < 0.5, false);
                }
                else
                {
                    fm1 = new FixturedMatch(target.Round, mu1, rng.NextDouble() < 0.5, false);
                    fm2 = new FixturedMatch(target.Round, mu2, rng.NextDouble() < 0.5, false);
                }
                target.Round.Matches.Remove(target);
                target.Round.Matches.Remove(swapper);
                target.Round.Matches.Add(fm1);
                target.Round.Matches.Add(fm2);
                fixtured[target.Matchup.Key].Remove(target);
                fixtured[swapper.Matchup.Key].Remove(swapper);
                fixtured[fm1.Matchup.Key].Add(fm1);
                fixtured[fm2.Matchup.Key].Add(fm2);
            }

        }

        /// <summary>
        /// Stage Two
        /// If we have deliberately scheduled too many Rounds, take out the excess games
        /// RoundNumber is abused as an ordering mechanism
        /// (comments below from early in the season)
        /// Remove return matchups but group the byes together
        /// Would love to have three in Rounds 10-11, five in the rest (before reshuffle)
        /// </summary>
        public void RemoveExtras()
        {
            List<FixturedMatchupList> duplicateList = fixtured.Where(l => l.Count > 1).ToList();
            foreach (FixturedMatchupList l in duplicateList)
            {
                FixturedMatch dupe = l.Fixtured.Last();
                dupe.Round.Matches.Remove(dupe);
                fixtured[dupe.Matchup.Key].Remove(dupe);
            }

            // Renumber the last two whole rounds to stay last
            int dummy = 99;
            foreach (FixturedRound completeRound in Rounds.Where(r => r.Matches.Count == 9).OrderBy(rr => -rr.RoundNumber))
            {
                completeRound.RoundNumber = dummy--;
                if (dummy < 98)
                    break;
            }
            //Rounds.Last(r => r.Matches.Count == 9).RoundNumber = 99;
            // Find the rounds that have byes
            IEnumerable<FixturedRound> byeRounds = Rounds.Where(r => r.RoundNumber > 14 && r.Matches.Count < 9).OrderBy(rr => rr.Matches.Count);
            int newOrder = 50;
            foreach (FixturedRound bye in byeRounds)
                bye.RoundNumber = newOrder++;

            // Sort by the temporary RoundNumber
            Rounds.Sort((r1, r2) => (r1.RoundNumber - r2.RoundNumber));
            // And set it correctly
            int roundNumber = 1;
            Rounds.ForEach(r => r.RoundNumber = roundNumber++);
        }

        /// <summary>
        /// Stage Three
        /// Give each team the same number of home & away fixtures (or within one, for an odd number of matches)
        /// Features sleight-of-hand with the clubIndex. Yikes!
        /// </summary> 
        public void BalanceHomeAway()
        {
            // Find an unbalanced team and remove some imbalance. Repeat until there is enough cardboard under all the legs

            int[] homeByClub = HomeByClubArray();
            while (homeByClub.Max() > 9 || homeByClub.Min() < 8)
            {
                // Negative index means too low, positive means too high
                List<int> imbalanced = new List<int>();
                for (int i = 0; i < homeByClub.Length; i++)
                {
                    if (homeByClub[i] < 8)
                        imbalanced.Add(-(i+1));
                    else if (homeByClub[i] > 9)
                        imbalanced.Add(i+1);
                }

                // Choose one at random
                int rand1 = rng.Next(imbalanced.Count());
                bool tooHigh = (imbalanced[rand1] > 0);
                int clubIndex = Math.Abs(imbalanced[rand1]) - 1;   // Remember we offset this earlier to make the sign meaningful
                // Find all their moveable games against clubs that aren't similarly imbalanced
                List<FixturedMatch> candidates = new List<FixturedMatch>();
                foreach (FixturedMatchupList list in Fixtured.Where(l => l.Matchup.Contains(clubIndex)))
                {
                    int oppoIndex = list.Matchup.Index1 + list.Matchup.Index2 - clubIndex;
                    if ((tooHigh && homeByClub[oppoIndex] < 9) || (!tooHigh && homeByClub[oppoIndex] > 8))
                    {
                        foreach (FixturedMatch fm in list.Fixtured.Where(f => !f.IsLocked))
                        {
                            if (tooHigh && (fm.IsHome && fm.Matchup.Index1 == clubIndex || !fm.IsHome && fm.Matchup.Index2 == clubIndex))
                                candidates.Add(fm);
                            else if (!tooHigh && (fm.IsHome && fm.Matchup.Index2 == clubIndex || !fm.IsHome && fm.Matchup.Index1 == clubIndex))
                                candidates.Add(fm);
                        }
                    }
                }
                if (candidates.Count() > 0)
                {
                    int rand2 = rng.Next(candidates.Count());
                    candidates[rand2].IsHome = !candidates[rand2].IsHome;
                }

                homeByClub = HomeByClubArray();
            }
        }

        public int[] HomeByClubArray()
        {
            int[] homeByClub = new int[18];
            foreach (FixturedRound r in Rounds)
            {
                foreach (FixturedMatch fm in r.Matches)
                    homeByClub[fm.IsHome ? fm.Matchup.Club1.Index : fm.Matchup.Club2.Index]++;
            }
            return homeByClub;
        }

        public override string ToString()
        {
            string s = "";
            foreach (FixturedRound r in Rounds)
                s += r.ToString() + System.Environment.NewLine;
            return s;
        }

        public string ToCSV()
        {
            string s = "";
            foreach (FixturedRound r in Rounds)
                s += r.ToCSV();
            return s;
        }
    }
}
