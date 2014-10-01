using System.Collections.Generic;
using SpecSalad;

namespace Calculator.Tasks
{
    public class SeeTheAnswer : ApplicationTask
    {
        protected override object Perform_Task_With(IDictionary<string, string> details)
        {
            return Role.LookAtTheDisplay();
        }
    }
}