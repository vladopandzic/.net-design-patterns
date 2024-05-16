using NSubstitute;

namespace VP.DesignPatterns.Iterator.Tests
{
    [TestFixture]
    public class IteratorPatternStructuralTests
    {
        [Test]
        public void IteratorInitializationTest()
        {
            var books = new List<Book>
            {
                new Book("Book1", "Author1"),
                new Book("Book2", "Author2"),
                new Book("Book3", "Author3")
            };

            var iterator = new BookIterator(books);

            Assert.IsNotNull(iterator);
            Assert.That(iterator.Current, Is.EqualTo(books[0]));
        }

        [Test]
        public void IteratorMovementTest()
        {
            var books = new List<Book>
            {
                new Book("Book1", "Author1"),
                new Book("Book2", "Author2"),
                new Book("Book3", "Author3")
            };

            var iterator = new BookIterator(books);

            Assert.IsTrue(iterator.MoveNext());
            Assert.That(iterator.Current, Is.EqualTo(books[1]));

            Assert.IsTrue(iterator.MoveNext());
            Assert.That(iterator.Current, Is.EqualTo(books[2]));

            Assert.IsFalse(iterator.MoveNext());
        }

    }
}