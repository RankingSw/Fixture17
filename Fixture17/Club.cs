using System;
using System.Collections.Generic;
using System.Text;

namespace Fixture17
{
    ///<summary>
    ///AFL clubs in 2020
    ///</summary>
    public class Club
    {
        public static List<Club> Clubs { get; private set; }
        public int Index { get; set; }
        public string Name { get; set; }
        public string Abbrev { get; set; }

        public Club(int id, string name, string abbrev)
        {
            Index = id;
            Name = name;
            Abbrev = abbrev;
        }

        public static void Initialise()
        {
            Clubs = new List<Club>(18);
            Clubs.Add(new Club(0, "Adelaide", "Adel"));
            Clubs.Add(new Club(1, "Brisbane", "Bris"));
            Clubs.Add(new Club(2, "Carlton", "Carl"));
            Clubs.Add(new Club(3, "Collingwood", "Coll"));
            Clubs.Add(new Club(4, "Essendon", "Ess"));
            Clubs.Add(new Club(5, "Fremantle", "Freo"));
            Clubs.Add(new Club(6, "Geelong", "Geel"));
            Clubs.Add(new Club(7, "Gold Coast", "G.C."));
            Clubs.Add(new Club(8, "GWS", "GWS"));
            Clubs.Add(new Club(9, "Hawthorn", "Haw"));
            Clubs.Add(new Club(10, "Melbourne", "Melb"));
            Clubs.Add(new Club(11, "North Melb", "N.M."));
            Clubs.Add(new Club(12, "Port Adel" , "P.A."));
            Clubs.Add(new Club(13, "Richmond", "Rich"));
            Clubs.Add(new Club(14, "St Kilda", "St.K"));
            Clubs.Add(new Club(15, "Sydney", "Syd"));
            Clubs.Add(new Club(16, "West Coast", "WCE"));
            Clubs.Add(new Club(17, "W Bulldogs", "W.B."));
        }
    }
}
