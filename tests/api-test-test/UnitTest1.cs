using System;
using Xunit;


namespace api_test_test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var pid = api_test.BL.Pid.Get();
            Assert.True(pid >= 0);
        }
    }
}
