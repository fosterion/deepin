using Deepin.Collections.Interfaces.IEnumerableExample;
using Deepin.Shared.Models.Elements;

namespace Deepin.Collections.Concrete
{
    class Garage : Container
    {
        internal override void Create()
        {
            CreateGarage();
        }

        private void CreateGarage()
        {
            var garage = new CustomEnumerable<Car>
            {
                new Car("Audi", 240),
                new Car("BMW", 280)
            };

            foreach (Car car in garage)
            {
                car.ShowInfo();
            }
        }
    }
}
