namespace clashofclans.server.Models
{
    public class ClanData
    {
        public string Tag { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public Location Location { get; set; }
        public bool IsFamilyFriendly { get; set; }
        public IconUrls BadgeUrls { get; set; }
        public int ClanLevel { get; set; }
        public int ClanPoints { get; set; }
        public int ClanBuilderBasePoints { get; set; }
        public int ClanCapitalPoints { get; set; }
        public LeagueData CapitalLeague { get; set; }
        public int RequiredTrophies { get; set; }
        public string WarFrequency { get; set; }
        public int WarWinStreak { get; set; }
        public int WarWins { get; set; }
        public bool IsWarLogPublic { get; set; }
        public LeagueData WarLeague { get; set; }
        public int Members { get; set; }
        public IEnumerable<MembersData> MemberList { get; set; }
    }

    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsCountry { get; set; }
        public string CountryCode { get; set; }

        public Location(int id, string name, bool isCountry, string countryCode)
        {
            Id = id;
            Name = name;
            IsCountry = isCountry;
            CountryCode = countryCode;
        }
    }

    public class IconUrls
    {
        public string Tiny { get; set; }
        public string Small { get; set; }
        public string Medium { get; set; }
        public string Large { get; set; }
        
        public IconUrls(string tiny, string small, string medium, string large)
        {
            Tiny = tiny;
            Small = small;
            Medium = medium;
            Large = large;
        }
    }

    public class LeagueData
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public LeagueData(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public class MembersData
    {
        public string Tag { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public int TownHallLevel { get; set; }
        public int ExpLevel { get; set; }
        public MemberLeague League { get; set; }
        public int Trophies { get; set; }
        public int BuilderBaseTrophies { get; set; }
        public int ClanRank { get; set; }
        public int PreviousClanRank { get; set; }
        public int Donations {  get; set; }
        public int DonationsReceived { get; set; }
        public LeagueData BuilderBaseLeague { get; set; }
    }

    public class MemberLeague
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IconUrls IconUrls { get; set; }

        public MemberLeague(int id, string name, IconUrls iconUrls)
        {
            Id = id;
            Name = name;
            IconUrls = iconUrls;
        }
    }
}
