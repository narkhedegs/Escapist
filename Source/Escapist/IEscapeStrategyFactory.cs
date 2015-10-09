namespace Narkhedegs
{
    /// <summary>
    /// Provides functionality to select correct implementation of <see cref="IEscapeStrategy"/> at runtime.
    /// </summary>
    public interface IEscapeStrategyFactory
    {
        /// <summary>
        /// Selects and instantiates a correct implementation of <see cref="IEscapeStrategy"/> based on the current 
        /// operating system.
        /// </summary>
        /// <returns>Implementation of <see cref="IEscapeStrategy"/></returns>
        IEscapeStrategy Create();
    }
}
