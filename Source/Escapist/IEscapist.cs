using System.Collections.Generic;

namespace Narkhedegs
{
    /// <summary>
    /// Provides methods to properly escape command line arguments.
    /// </summary>
    public interface IEscapist
    {
        /// <summary>
        /// Escapes given command line arguments.
        /// </summary>
        /// <param name="arguments">Command line arguments.</param>
        /// <returns>
        /// Escaped command line arguments.
        /// </returns>
        IEnumerable<string> Escape(IEnumerable<string> arguments);
    }
}
