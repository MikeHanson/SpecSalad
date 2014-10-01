using System.Collections.Generic;

namespace SpecSalad.features.Tasks
{
    public class StoreInTheTask : ApplicationTask
    {
        protected override object Perform_Task_With(IDictionary<string, string> details)
        {
            StoreValue("FromTask",  details.DefaultValue());

            return null;
        }
    }
}