using System;
using System.Collections.Generic;

namespace SpecSalad.features.Tasks
{
    public class SeeTheAnswers : ApplicationTask
    {
        protected override object Perform_Task_With(IDictionary<string, string> details)
        {
            return Role.GetTheAnswers();
        }
    }
}