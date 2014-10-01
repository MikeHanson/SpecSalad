using System.Collections.Generic;

namespace SpecSalad.features.Tasks
{
    public class RetrieveTheAnswer : ApplicationTask
    {
        protected override object Perform_Task_With(IDictionary<string, string> details)
        {
            return Role.Retrieve("the_value");
        }
    }
}