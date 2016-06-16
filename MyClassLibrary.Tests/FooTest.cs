using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary.Tests
{
    [TestFixture]
    public class FooTest
    {
        [Test]
        public void DoFooShouldReturnFoo()
        {
            Foo foo = new Foo();
            Assert.AreEqual("Foo", foo.DoFoo());
        }
    }
}
