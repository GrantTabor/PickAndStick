using PickAndStick.Models;
using System.Collections.Generic;
using PickAndStick.Domain.Managers;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using PickAndStick.Domain.Managers;
using PickAndStick.Domain.LeagueInputs;

namespace PickAndStick.API.Controllers
{

    [ApiController]
    [Route("League")]
    public class LeagueController : ControllerBase
    {
        [HttpPost]
        public ActionResult<League> makeLeague([FromBody]LeagueNameInput leagueName)
        {
            LeagueManager LM = new LeagueManager();
            League league = LM.makeLeague(leagueName.LeagueName);

               //Player player = PM.makePlayer(newUser.Username, newUser.Email, newUser.Password);
               //return player;
            return league;
        }
        [HttpGet]
        public ActionResult<List<League>> getLeagues()
        {
            LeagueManager LM = new LeagueManager();
            List<League> leagues = LM.GetLeagues();
            return leagues;
        }
    }



}



