using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Narkhedegs
{
    /// <summary>
    /// Provides functionality to escape command line arguments for windows operating system.
    /// </summary>
    public class WindowsEscapeStrategy : IEscapeStrategy
    {
        /// <summary>
        /// Escapes given command line arguments using windows operating system specific rules. This method assumes that the 
        /// arguments parameter is not null or empty. More information - http://stackoverflow.com/questions/5510343/escape-command-line-arguments-in-c-sharp
        /// </summary>
        /// <param name="arguments">Command line arguments.</param>
        /// <returns>Escaped command line arguments.</returns>
        public IEnumerable<string> Escape(IEnumerable<string> arguments)
        {
            var escapedArguments = new List<string>();

            var argumentsArray = arguments?.ToArray() ?? new string[] {};

            if (argumentsArray.Any())
            {
                foreach (var argument in argumentsArray)
                {
                    var escaped = Regex.Replace(argument, @"(\\*)" + "\"", @"$1\$0");
                    escaped = Regex.Replace(escaped, @"^(.*\s.*?)(\\*)$", "\"$1$2$2\"");

                    escapedArguments.Add(escaped);
                }
            }

            return escapedArguments;
        }
    }
}
