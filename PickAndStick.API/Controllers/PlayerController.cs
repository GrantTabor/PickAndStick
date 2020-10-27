using PickAndStick.Models;
using System.Collections.Generic;
using PickAndStick.Domain.Managers;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using PickAndStick.Domain.PlayerInputs;
using PickAndStick.Domain;
using System.Web.Http.Cors;


namespace PickAndStick.API.Controllers
{

    [ApiController]
    [Route("Player")]
    [EnableCors(origins: "http://localhost:3000", headers: "*", methods: "*")]
    public class PlayerController : ControllerBase
    {
        [HttpPost]
        public ActionResult<Player> makePlayer([FromBody]AddUserInput newUser)
        {
            PlayerManager PM = new PlayerManager();
            Player player = PM.makePlayer(newUser.Username, newUser.Email, newUser.Password);
            return player;
        }
        [HttpGet]

        public ActionResult<List<Player>> getPlayers()
        {
            PlayerManager PM = new PlayerManager();
            List<Player> players = PM.getPlayers();

            return players;
        }
        [HttpGet("{id}")]
        public ActionResult<Player> getPlayer(int id)
        {
            PlayerManager PM = new PlayerManager();
            Player player = PM.getPlayer(id);
            if (player != null)
            {
                return player;
            }
            else
            {
                return NotFound();
            }

        }
        [HttpDelete("{id}")]
        public ActionResult deletePlayer(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Not a valid student id");
            }

            PlayerManager PM = new PlayerManager();
            PM.deletePlayer(id);
            Console.WriteLine("testing");
            return Ok();
        }
        [HttpPut("{id}")]
        public ActionResult editName(int id, [FromBody]UserNameInput userNameChange )
        {
            //string newUserName = userName.ToString();
            
            //string newUserName = System.Text.Json.JsonSerializer.Deserialize(String)(userName);
            PlayerManager PM = new PlayerManager();
            PM.editPlayerUsername(id, userNameChange.username);
            return Ok();
        }

        [HttpPost]
        [Route("login")]
        public ActionResult<Player> login([FromBody]UserLoginInput userLogin)
        {
            PlayerManager PM = new PlayerManager();
            Player player = PM.selectPlayerByUsername(userLogin.Username);
            if(player == null)
            {
                return NotFound();
            }

            if (player.Password == userLogin.Password)
            {
                return player;
            }
            else
            {
                return NotFound();
            }
            
        }
    }

    

}


    
