using Deepin.Collections.Interfaces.IEnumerableExample;
using Deepin.Shared.Models.Elements;

namespace Deepin.Collections.Concrete
{
    class Zoo : Container
    {
        internal override void Create()
        {
            CreateZoo();
        }

        private void CreateZoo()
        {
            var animals = new Animal[]
            {
                new Animal("Bear", 12),
                new Animal("Fox", 2),
                new Animal("Zebra", 7)
            };

            var zoo = new CustomEnumerable<Animal>(animals);

            foreach (Animal animal in zoo)
            {
                animal.ShowInfo();
            }
        }
    }
}
