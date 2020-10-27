using PickAndStick.Models;
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace PickAndStick.Domain.Managers
{
    public class PlayerManager
    {
        public Player makePlayer(string playerName, string playerEmail, string playerPassword)
        {
            using (var db = new PickAndStick.Models.PickerContext())
            {
                Player player = new Player { Name = playerName, Email = playerEmail, Password = playerPassword };
                db.Add(player);
                db.SaveChanges();

                return player;
            }
        }
        public List<Player> getPlayers()
        {
            using (var db = new PickAndStick.Models.PickerContext())
            {
                var players = db.Players.ToList();

                return players;
            }
        }
        public Player getPlayer(int playerId)
        {
            using (var db = new PickAndStick.Models.PickerContext())
            {

                var player = db.Players.FirstOrDefault(x => x.Id == playerId);

                return player;
            }
        }
        public void deletePlayer(int playerId)
        {
            using (var db = new PickAndStick.Models.PickerContext())
            {
                var player = db.Players.FirstOrDefault(x => x.Id == playerId);

                db.Remove(player);
                db.SaveChanges();
            }

        }
        public void editPlayerUsername(int playerId, string newUsername)
        {
            using (var db = new PickAndStick.Models.PickerContext())
            {
                var player = db.Players.FirstOrDefault(x => x.Id == playerId);

                player.Name = newUsername;
                db.SaveChanges();
            }
        }
        public Player selectPlayerByUsername(string username)
        {
            using (var db = new PickAndStick.Models.PickerContext())
            {
                var player = db.Players.FirstOrDefault(x => x.Name == username);

                return player;
            }
        }
    }
}
