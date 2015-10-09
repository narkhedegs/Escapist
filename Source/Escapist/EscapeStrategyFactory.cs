using System;

namespace Narkhedegs
{
    /// <summary>
    /// Provides functionality to select correct implementation of <see cref="IEscapeStrategy"/> at runtime.
    /// </summary>
    public class EscapeStrategyFactory : IEscapeStrategyFactory
    {
        /// <summary>
        /// Selects and instantiates a correct implementation of <see cref="IEscapeStrategy"/> based on the current 
        /// operating system.
        /// </summary>
        /// <returns>Implementation of <see cref="IEscapeStrategy"/></returns>
        public IEscapeStrategy Create()
        {
            IEscapeStrategy escapeStrategy = null;

            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                case PlatformID.Xbox:
                    escapeStrategy = new WindowsEscapeStrategy();
                    break;
                case PlatformID.MacOSX:
                    escapeStrategy = new MacEscapeStrategy();
                    break;
                case PlatformID.Unix:
                    escapeStrategy = new UnixEscapeStrategy();
                    break;
            }

            return escapeStrategy;
        }
    }
}
