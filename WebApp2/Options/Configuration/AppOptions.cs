using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp2.Options.Configuration
{
    /// <summary>
    /// App config options.
    /// </summary>
    public class AppConfigOptions
    {
        /// <summary>
        /// <see cref="Configuration.Trace"/>
        /// </summary>
        public Trace Trace { get; set; }
    }

    /// <summary>
    /// The app trace config section.
    /// </summary>
    public class Trace
    {
        public string TraceKey { get; set; }
        public bool TraceSql { get; set; }
    }
}
