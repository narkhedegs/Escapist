using System;
using NUnit.Framework;

namespace Narkhedegs.Tests
{
    [TestFixture]
    public class when_constructing_escapist
    {
        [Test]
        public void it_should_throw_ArgumentNullException_if_escapeStrategyFactory_parameter_is_null()
        {
            Assert.Throws<ArgumentNullException>(() => new Escapist(null));
        }
    }
}
