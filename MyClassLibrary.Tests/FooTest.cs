namespace MyClassLibrary.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class FooTest
    {
        [Test]
        public void DoFooShouldReturnFoo()
        {
            Assert.AreEqual("Foo", Foo.DoFoo());
        }
    }
}
