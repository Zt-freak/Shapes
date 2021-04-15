using System;
using Xunit;
using Shapes.Models;

namespace Shapes.Tests
{
    public class RectangleTests
    {
        [Fact]
        public void GetAreaTest()
        {
            Rectangle Spongebob = new Rectangle
            {
                Width = 5,
                Height = 10
            };

            Assert.Equal(50, Spongebob.Area);
        }
    }
}
