using PickAndStick.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PickAndStick.Domain.Managers
{
    public class PickManager
    {
        public WeekPick MakeWeekPick(int playerId, int seasonId)
        {
            WeekPick weekPick = new WeekPick{ PlayerId = playerId, SeasonId = seasonId};
            return weekPick;
        }


        public WeekPick PopulateWeekPick(WeekPick weekPick, List<Pick> picks )
        {
            foreach(Pick pick in picks)
            {
                int numSelected = 0;

                foreach(Choice choice in pick.Choices)
                {
                    if (choice.IsSelected == true) numSelected++;
                }
                if (numSelected != 1)
                {
                    throw new System.ArgumentException("Must have one choice selected", "original");
                }
            }
            weekPick.PicksByConfidence = picks;

            return weekPick;
        }
        public List<Pick> MakePicks()
        {

            List<Pick> picks = new List<Pick>();
            return picks;
        }
        public List<Pick> AddToPickList(List<Pick> picks, Pick pick)
        {
            picks.Add(pick);
            return picks;
        }
    }
}

