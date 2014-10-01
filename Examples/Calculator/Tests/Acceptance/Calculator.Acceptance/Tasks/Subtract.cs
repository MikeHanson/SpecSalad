using System.Collections.Generic;
using SpecSalad;

namespace Calculator.Tasks
{
    public class Subtract : ApplicationTask
    {
        protected override object Perform_Task_With(IDictionary<string, string> details)
        {
            Role.Enter(int.Parse(details["from_the_number"]));
            Role.Press('-');
            Role.Enter(int.Parse(details["the_number"]));
            Role.Press('=');

            return null;
        }
    }
}