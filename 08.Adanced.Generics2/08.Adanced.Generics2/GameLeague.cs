using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Adanced.Generics2
{
    internal class GameLeague<T1, T2> : SportDivsion<T1>
    {
        private Dictionary<T1, List<T2>> Leagues { get; set; } = new Dictionary<T1, List<T2>>();
        private T1 LeagueType { get; set; }
        private T2 TeamName { get; set; }

        public void AddTeam(T1 leagueType, T2 teamName)
        {
            LeagueType = leagueType;
            TeamName = teamName;
            
            bool check = LeagueCheck(leagueType,teamName);
            if (check)
            {
                if (!Leagues.ContainsKey(leagueType))
                { 
                Leagues[LeagueType]= new List<T2>();
                }
                Leagues[LeagueType].Add(teamName);
            }
            else
            {
                throw new ArgumentNullException("Choose a different league");
            }
        }
        private bool LeagueCheck(T1 leagueType, T2 teamName)
        {
            //Leagues.Add();
            if (leagueType.GetType() == teamName.GetType())
            {
                return true;
            }
            else { return false; }
        }
        public void PrintTeams()
        {
            foreach (var league in Leagues)
            {
                Console.WriteLine($"League: {league.Key.GetType()} \tTeams: {string.Join(", ", league.Value)}");
            }
        }
    }
}
