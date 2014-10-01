using System.Collections.Generic;

namespace SpecSalad.features.Tasks
{
    public class DoTheSubtractOneTask : ApplicationTask
    {
        protected override object Perform_Task_With(IDictionary<string, string> details)
        {
            Role.SubtractOne();

            return null;
        }
    }
}