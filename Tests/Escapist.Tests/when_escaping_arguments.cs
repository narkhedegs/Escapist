using System;
using NUnit.Framework;

namespace Narkhedegs.Tests
{
    [TestFixture]
    public class when_escaping_arguments
    {
        private IEscapist _escapist;

        [SetUp]
        public void SetUp()
        {
            _escapist = new Escapist();
        }

        [Test]
        public void it_should_throw_ArgumentNullException_if_arguments_parameter_is_null()
        {
            Assert.Throws<ArgumentNullException>(() => _escapist.Escape(null));
        }
    }
}
