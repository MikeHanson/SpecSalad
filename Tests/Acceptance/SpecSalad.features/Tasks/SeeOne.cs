using System;
using System.Collections.Generic;

namespace SpecSalad.features.Tasks
{
    public class SeeOne : ApplicationTask
    {
        protected override object Perform_Task_With(IDictionary<string, string> details)
        {
            Role.ShouldContainOne();

            return null;
        }
    }
}