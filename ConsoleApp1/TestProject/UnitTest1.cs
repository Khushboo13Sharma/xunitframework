using System;
using Xunit;
using TestFramework;

namespace TestFramework
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var x = new Program();
            int y = x.Add(5, 6);
            Assert.Equal(11, y);
        }
    }
}
