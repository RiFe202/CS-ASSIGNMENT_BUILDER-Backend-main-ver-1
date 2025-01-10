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

        [Assignment(2)]
        public void TestClassesAndObjects()
        {
            var person = new Person { Name = "John Doe", Age = 30 };
            var anotherPerson = new Person { Name = "Jane Doe", Age = 25 };

            Assert.Equal("John Doe", person.Name);
            Assert.Equal(30, person.Age);
            Assert.NotEqual(person, anotherPerson);
        }

        [Assignment(3)]
        public void TestDataStructures()
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };
            var dictionary = new Dictionary<string, int> { { "one", 1 }, { "two", 2 } };

            Assert.Equal(5, list.Count);
            Assert.Equal(1, dictionary["one"]);
            Assert.Equal(2, dictionary["two"]);
        }
    }
}