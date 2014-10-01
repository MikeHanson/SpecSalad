using System.Collections.Generic;
using SpecSalad;

namespace Calculator.Acceptance.Tasks
{
    public class Add : ApplicationTask
    {
        protected override object Perform_Task_With(IDictionary<string, string> details)
        {
            Role.Enter(int.Parse(details["the_number"]));
            Role.Press('+');
            Role.Enter(int.Parse(details["to_the_number"]));
            Role.Press('=');

            return null;
        }
    }
}