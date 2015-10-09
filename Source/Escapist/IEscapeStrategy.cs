using System.Collections.Generic;

namespace Narkhedegs
{
    /// <summary>
    /// Provides operating system specific functionality to escape command line arguments.
    /// </summary>
    public interface IEscapeStrategy
    {
        /// <summary>
        /// Escapes given command line arguments using operating system specific rules. This method assumes that the 
        /// arguments parameter is not null or empty.
        /// </summary>
        /// <param name="arguments">Command line arguments.</param>
        /// <returns>Escaped command line arguments.</returns>
        IEnumerable<string> Escape(IEnumerable<string> arguments);
    }
}
