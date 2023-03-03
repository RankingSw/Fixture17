﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Fixture17
{
    public class FixturedMatchupList
    {
        public Matchup Matchup { get; private set; }
        public string Pair { get { return Matchup.ToString(); } }
        public List<FixturedMatch> Fixtured { get; private set; }
        public int Count { get { return Fixtured.Count; } }
        public string Rounds
        {
            get
            {
                if (Count == 0)
                    return "—";
                string s = Fixtured[0].Round.RoundNumber.ToString();
                for (int i = 1; i < Count; i++)
                    s += ", " + Fixtured[i].Round.RoundNumber.ToString();
                return s;
            }
        }

        public FixturedMatchupList(int key)
        {
            Matchup = Matchup.AllMatchups[key];
            Fixtured = new List<FixturedMatch>();
        }

        public void Add(FixturedMatch fm)
        {
            Fixtured.Add(fm);
        }

        public void Remove(FixturedMatch fm)
        {
            Fixtured.Remove(fm);
        }
    }

    public class FixturedMatch
    {
        public FixturedRound Round { get; private set; }
        public Matchup Matchup { get; private set; }
        public bool IsHome { get; set; }
        public DateTime Scheduled { get; private set; }
        public bool IsLocked { get; private set; }
        public FixturedMatch(FixturedRound round, Matchup matchup, bool isHome, bool isLocked, int? exactDate = null)
        {
            Round = round;
            Matchup = matchup;
            IsHome = isHome;
            IsLocked = isLocked;
            if (exactDate == null)
                Scheduled = Round.Saturday;
            else
                Scheduled = DateTime.FromOADate((double)exactDate);
        }

        public override string ToString()
        {
            if (IsHome)
                return Matchup.Club1Abbr + " v " + Matchup.Club2Abbr;
            else
                return Matchup.Club2Abbr + " v " + Matchup.Club1Abbr;
        }

        public string ToCSV()
        {
            string s = Round.RoundNumber.ToString() + "," + Scheduled.ToShortDateString() + ",";
            if (IsHome)
                s += Matchup.Club1.Name + "," + Matchup.Club2.Name;
            else
                s += Matchup.Club2.Name + "," + Matchup.Club1.Name;
            return s;
        }
    }
}