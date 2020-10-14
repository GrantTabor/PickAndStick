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
    }
}
