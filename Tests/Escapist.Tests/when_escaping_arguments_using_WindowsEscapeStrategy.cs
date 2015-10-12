using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Narkhedegs.Tests
{
    [TestFixture]
    public class when_escaping_arguments_using_WindowsEscapeStrategy
    {
        private WindowsEscapeStrategy _windowsEscapeStrategy;

        [SetUp]
        public void SetUp()
        {
            _windowsEscapeStrategy = new WindowsEscapeStrategy();
        }

        [Test]
        public void it_should_return_empty_array_if_arguments_parameter_is_null()
        {
            var result = _windowsEscapeStrategy.Escape(null);

            Assert.IsNotNull(result);
            Assert.IsInstanceOf<IEnumerable<string>>(result);
            Assert.That(!result.Any());
        }

        [Test]
        public void it_should_return_empty_array_if_arguments_parameter_is_empty()
        {
            var result = _windowsEscapeStrategy.Escape(new string[] {});

            Assert.IsNotNull(result);
            Assert.IsInstanceOf<IEnumerable<string>>(result);
            Assert.That(!result.Any());
        }

        [Test]
        [TestCase(new[] { " " }, new[] { "\"" + " " + "\"" })]
        [TestCase(new[] { "hello" }, new[] { "hello" })]
        [TestCase(new[] { @"\hello\12\3\" }, new[] { @"\hello\12\3\" })]
        [TestCase(new[] { @"hello world" }, new[] { "\"hello world\"" })]
        public void it_should_escape_arguments_correctly(IEnumerable<string> input, IEnumerable<string> expected)
        {
            var actual = _windowsEscapeStrategy.Escape(input);

            var expectedArray = expected as string[] ?? expected.ToArray();
            var actualArray = actual as string[] ?? actual.ToArray();

            Assert.AreEqual(expectedArray.Length, actualArray.Length);
            for (var i = 0; i < expectedArray.Length; i++)
            {
                var expectedValue = expectedArray[i];
                var actualValue = actualArray[i];

                Assert.AreEqual(expectedValue, actualValue);
            }
        }
    }
}
