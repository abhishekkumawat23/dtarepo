using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace customadapter
{
    public class Class1
    {
        [Fact]
        public void Test1()
        {
            Console.WriteLine("hello XUnit");
            Assert.True(true);
        }
    }
}
