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

            using (var db = new PickAndStick.Models.PickerContext())
            {
                WeekPick weekPick = new WeekPick { PlayerId = playerId, SeasonId = seasonId };
                db.Add(weekPick);
                db.SaveChanges();

                return weekPick;
            }
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
        public Pick MakePick(List<Choice> choices, int weekPickId, int confidence)
        {
            using(var db = new PickAndStick.Models.PickerContext())
            {
                Pick pick = new Pick { Choices = choices, WeekPickId = weekPickId, Confidence = confidence };
                db.Add(pick);
                db.SaveChanges();

                return pick;
            }
        }
        public Choice MakeChoice(bool isSelected, string optionName)
        {
            using(var db = new PickAndStick.Models.PickerContext())
            {
                Choice choice = new Choice { IsSelected = isSelected, OptionName = optionName };
                db.Add(choice);
                db.SaveChanges();
                return choice;
            }
        }
    }
}

