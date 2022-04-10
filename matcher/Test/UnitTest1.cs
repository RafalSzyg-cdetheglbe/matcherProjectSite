using NUnit.Framework;
using System;
using WebApplication1.DB;
using Xunit;

namespace Test
{
    public class DummyTest
    {
        [Test]
        public void TestDummy()
        {
            string Name = null;
            string firstName = It.IsAny<string>(); // Dummy

            Action act = () => new Uzytkownik(firstName, Name);

            act.ShouldThrow<ArgumentNullException>();
        }
    }
}
