using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace SpecSalad.features.Tasks
{
    public class SeeTheFavouriteColour : ApplicationTask
    {
        protected override object Perform_Task_With(IDictionary<string, string> details)
        {
            var votes = (Table)Retrieve("whats your favourite colour");

            string winningColour = "";
            int[] winningVoteCount = {0};

            foreach (var row in votes.Rows.Where(row => Convert.ToInt32(row["vote"]) > winningVoteCount[0]))
            {
                winningColour = row["answer"];
                winningVoteCount[0] = Convert.ToInt32(row["vote"]);
            }

            return winningColour;
        }
    }
}