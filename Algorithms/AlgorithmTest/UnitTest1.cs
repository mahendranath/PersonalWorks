using System;
using Xunit;
using Algorithms;

namespace AlgorithmTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestSayHi()
        {
            HelloWorld helloWorld = new HelloWorld();
            Console.WriteLine(helloWorld.SayHi());
            Assert.True("Hi!!" == helloWorld.SayHi());
        }
    }
}
