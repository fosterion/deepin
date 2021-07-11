using Deepin.Collections.Iterators.YieldExample;
using Deepin.Shared.Models.Elements;

namespace Deepin.Collections.Concrete
{
    class Library : Container
    {
        internal override void Create()
        {
            CreateLibrary();
        }

        private static void CreateLibrary()
        {
            var books = new Book[]
            {
                new Book("Moby Dick", "Herman Melville"),
                new Book("Hamlet", "William Shakespeare"),
                new Book("The Odyssey", "Homer"),
                new Book("The Divine Comedy", "Dante Alighieri"),
                new Book("The Adventures of Huckleberry Finn", "Mark Twain"),
                new Book("Crime and Punishment", "Fyodor Dostoyevsky")
            };

            var library = new CustomYield<Book>(books);

            foreach (Book book in library.GetElements(3))
            {
                book.ShowInfo();
            }
        }
    }
}
