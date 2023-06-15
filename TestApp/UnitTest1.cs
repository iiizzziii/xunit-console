using cons_app;

namespace TestApp
{
    public class UnitTest1
    {
        [Fact]
        public void EvenTestTrue()
        {
            Assert.True(Program.IsEven(2));
        }

        [Fact]
        public void EvenTestFalse()
        {
            Assert.False(Program.IsEven(3));
        }
    }
}