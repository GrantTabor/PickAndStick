using PickAndStick.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PickAndStick.Domain.Managers
{
    public class LeagueManager
    {
        public League makeLeague(string name)
        {
            using (var db = new PickAndStick.Models.PickerContext())
            {
                League newLeague = new League { Name = name };

                db.Add(newLeague);
                db.SaveChanges();

                return newLeague;
            }
        }
        public List<League> GetLeagues()
        {
            using (var db = new PickAndStick.Models.PickerContext())
            {
                List<League> leagues = db.Leagues.ToList();

              
                return leagues;
            }
        }
        public Season makeSeason(int leagueId)
        {
            using (var db = new PickAndStick.Models.PickerContext())
            {
                Season season = new Season { LeagueId = leagueId };

                db.Add(season);
                db.SaveChanges();

                return season;
            }
        }
        public PlayerSeason makePlayerSeason(int seasonId, int playerId)
        {
            using (var db = new PickAndStick.Models.PickerContext())
            {
                PlayerSeason playerSeason = new PlayerSeason { SeasonId = seasonId, PlayerId = playerId };

                db.Add(playerSeason);
                db.SaveChanges();

                return playerSeason;
            }
        }
    }
}
