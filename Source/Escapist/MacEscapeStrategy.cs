using System.Collections.Generic;

namespace Narkhedegs
{
    /// <summary>
    /// Provides functionality to escape command line arguments for mac operating system.
    /// </summary>
    public class MacEscapeStrategy : IEscapeStrategy
    {
        /// <summary>
        /// Escapes given command line arguments using mac operating system specific rules. This method assumes that the 
        /// arguments parameter is not null or empty.
        /// </summary>
        /// <param name="arguments">Command line arguments.</param>
        /// <returns>Escaped command line arguments.</returns>
        public IEnumerable<string> Escape(IEnumerable<string> arguments)
        {
            throw new System.NotImplementedException();
        }
    }
}
