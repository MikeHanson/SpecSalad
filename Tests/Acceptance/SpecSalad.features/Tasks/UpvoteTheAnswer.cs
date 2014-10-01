using System.Collections.Generic;

namespace SpecSalad.features.Tasks
{
    public class UpVoteTheAnswer : ApplicationTask
    {
        protected override object Perform_Task_With(IDictionary<string, string> details)
        {
            Role.UpVoteAnswer(details.DefaultValue());

            return null;
        }
    }
}