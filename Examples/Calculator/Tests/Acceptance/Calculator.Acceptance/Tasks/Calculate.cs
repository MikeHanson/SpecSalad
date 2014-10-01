using System;
using System.Collections.Generic;
using SpecSalad;

namespace Calculator.Tasks
{
    public class Calculate : ApplicationTask
    {
        protected override object Perform_Task_With(IDictionary<string, string> details)
        {
            var sum = details["with_the_following"];

            var items = sum.Split(' ');

            foreach (var item in items)
            {
                int num;
                if (int.TryParse(item, out num))
                {
                    Role.Enter(num);
                }
                else
                {
                    Role.Press(Convert.ToChar(item));
                }
            }

            return null;
        }
    }
}