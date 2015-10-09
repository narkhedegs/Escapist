using System;
using System.Collections.Generic;

namespace Narkhedegs
{
    /// <summary>
    /// Provides methods to properly escape command line arguments.
    /// </summary>
    public class Escapist : IEscapist
    {
        private readonly IEscapeStrategyFactory _escapeStrategyFactory;

        /// <summary>
        /// Initializes a new instance of <see cref="Escapist"/>.
        /// </summary>
        public Escapist() : this(new EscapeStrategyFactory())
        {
            
        }

        /// <summary>
        /// Initializes a new instance of <see cref="Escapist"/>.
        /// </summary>
        /// <param name="escapeStrategyFactory">Implementation of <see cref="IEscapeStrategyFactory"/>.</param>
        public Escapist(IEscapeStrategyFactory escapeStrategyFactory)
        {
            if(escapeStrategyFactory == null)
                throw new ArgumentNullException(nameof(escapeStrategyFactory));

            _escapeStrategyFactory = escapeStrategyFactory;
        }

        /// <summary>
        /// Escapes given command line arguments.
        /// </summary>
        /// <param name="arguments">Command line arguments.</param>
        /// <returns>
        /// Escaped command line arguments.
        /// </returns>
        public IEnumerable<string> Escape(IEnumerable<string> arguments)
        {
            if(arguments == null)
                throw new ArgumentNullException(nameof(arguments));

            return _escapeStrategyFactory.Create().Escape(arguments);
        }
    }
}
