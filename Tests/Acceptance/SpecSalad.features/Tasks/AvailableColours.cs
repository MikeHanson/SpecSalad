using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace SpecSalad.features.Tasks
{
    public class AvailableColours : ApplicationTask
    {
        protected override object Perform_Task_With(IDictionary<string, string> details)
        {
            return (Table)this.Role.Retrieve("available colours");
        }
    }
}