using PickAndStick.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PickAndStick.Domain.Managers
{
    public class LeaguePlayerManager
    {
        public LeaguePlayer makeLeaguePlayer(int PlayerID, int LeagueID)
        {
            using (var db = new PickAndStick.Models.PickerContext())
            {

                LeaguePlayer newLeaguePlayer = new LeaguePlayer { PlayerId = PlayerID, LeagueId = LeagueID };

                db.Add(newLeaguePlayer);
                db.SaveChanges();

                return newLeaguePlayer;
            }
        }

    }
}
