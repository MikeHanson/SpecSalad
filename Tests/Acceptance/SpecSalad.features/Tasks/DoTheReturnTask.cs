using System;
using System.Collections.Generic;
using System.Linq;

namespace SpecSalad.features.Tasks
{
    public class DoTheReturnTask : ApplicationTask
    {
        private readonly List<string> _knownParameterNames = new List<string>
                                                             {
                                                                 "with_a_single_parameter",
                                                                 "with_parameter",
                                                                 "and_parameter"
                                                             };

        protected override object Perform_Task_With(IDictionary<string, string> details)
        {
            foreach(
                var parameterName in
                    this._knownParameterNames.Where(details.ContainsKey))
            {
                int paramValue;
                int.TryParse(details[parameterName], out paramValue);

                this.Role.Add(paramValue);
            }

            return true;
        }
    }
}