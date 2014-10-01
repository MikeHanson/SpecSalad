using System;
using System.Collections.Generic;
using SpecSalad;

namespace Calculator.Tasks
{
    public class SwitchOnTheCalculator : ApplicationTask
    {
        protected override object Perform_Task_With(IDictionary<string, string> details)
        {
            this.Role.SwitchOnCalculator();

            return null;
        }
    }
}