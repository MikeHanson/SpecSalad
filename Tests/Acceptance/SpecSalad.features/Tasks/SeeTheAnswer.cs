using System;
using System.Collections.Generic;

namespace SpecSalad.features.Tasks
{
    public class SeeTheAnswer : ApplicationTask
    {
        protected override object Perform_Task_With(IDictionary<string, string> details)
        {
            return Role.GetTheAnswer();
        }
    }
}
