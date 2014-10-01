using System.Collections.Generic;

namespace SpecSalad.features.Tasks
{
    public class Store : ApplicationTask
    {
        protected override object Perform_Task_With(IDictionary<string, string> details)
        {
            Role.StoreValue("the_value", details["the_value"]);

            return null;
        }
    }
}