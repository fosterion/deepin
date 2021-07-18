using Deepin.Collections.Iterators.YieldExample;
using Deepin.Shared.Models.Elements;

namespace Deepin.Collections.Concrete
{
    class Fridge : Container
    {
        internal override void Create()
        {
            CreateFridge();
        }

        private void CreateFridge()
        {
            var products = new Product[]
            {
                new Product("Beer", 120),
                new Product("Parrot", 25),
                new Product("Ketchup", 80)
            };

            var fridge = new CustomYield<Product>(products);

            foreach (Product product in fridge)
            {
                product.ShowInfo();
            }
        }
    }
}
