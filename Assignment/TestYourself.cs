using C_ASSIGNMENT_BUILDER.Engine.AssignmentBuilder;
using Xunit;

namespace C_ASSIGNMENT_BUILDER.CurrentAssignment
{
    public class TestYourself : AssignmentBase
    {
        [Assignment(1)]
        public void TestPrimitiveDataTypes()
        {
            int number = 42;
            float decimalNumber = 3.14f;
            bool isTrue = true;
            string text = "Hello, world!";

            Assert.Equal(42, number);
            Assert.Equal(3.14f, decimalNumber);
            Assert.True(isTrue);
            Assert.Equal("Hello, world!", text);
        }
    }
}