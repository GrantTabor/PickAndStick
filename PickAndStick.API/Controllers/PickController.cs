using PickAndStick.Models;
using System.Collections.Generic;
using PickAndStick.Domain.Managers;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using PickAndStick.Domain.PickInputs;

namespace PickAndStick.API.Controllers
{

    [ApiController]
    [Route("Pick")]
    public class PickController : ControllerBase
    {
        [HttpPost]
        [Route("WeekPick")]
        public ActionResult<WeekPick> MakeWeekPick([FromBody]WeekPickInput weekPickInput)
        {
            PickManager PM = new PickManager();
            WeekPick weekPick = PM.MakeWeekPick(weekPickInput.PlayerId, weekPickInput.SeasonId);
            return weekPick;
        }
        public ActionResult<Pick> MakePick([FromBody]PickInput pickInput)
        {
            PickManager PM = new PickManager();
            Pick pick = PM.MakePick(pickInput.Choices, pickInput.WeekPickId, pickInput.Confidence);
            return pick;
        }
       
    }



}



