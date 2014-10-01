using System;
using System.Collections.Generic;

namespace SpecSalad
{
    public abstract class ApplicationTask : TaskBase
    {
        public dynamic Role { get; set; }
        public Details Details { get; set; }

        public virtual object Perform_Task()
        {
            var details = new Dictionary<string, string>();

            for(var i = 0; i < this.Details.Count(); i++)
            {
                var key = this.Details.Key(i);
                details.Add(key, this.Details.Value_Of(key));
            }
            return this.Perform_Task_With(details);
        }

        protected abstract object Perform_Task_With(IDictionary<string, string> details);
    }
}