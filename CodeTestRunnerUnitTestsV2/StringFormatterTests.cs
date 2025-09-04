using CodeTestRunner;

namespace CodeTestRunnerUnitTestsV2
{
    public class Tests
    {
        [Test]
        public void ToCommaSepatatedList_WithEmptyArray_ReturnsEmptyString()
        {
            //Arrange & Act
            var sfOutput = StringFormatter.ToCommaSeparatedList([], "'");

            //Assert
            Assert.That(sfOutput, Is.EqualTo(string.Empty));

        }

        [Test]
        public void ToCommaSepatatedList_WithSingleItemArray_ReturnsQuotedItem()
        {
            //Arrange & Act
            var sfOutput = StringFormatter.ToCommaSeparatedList(["a"], "'");

            //Assert
            Assert.That(sfOutput, Is.EqualTo("'a'"));
        }

        [Test]
        public void ToCommaSepatatedList_WithMultipleItemsArray_ReturnsQuotedCommaSeparatedList()
        {
            //Arrange & Act
            var sfOutput = StringFormatter.ToCommaSeparatedList(["a", "b", "c"], "'");

            //Assert
            Assert.That(sfOutput, Is.EqualTo("'a', 'b', 'c'"));
        }
    }
}