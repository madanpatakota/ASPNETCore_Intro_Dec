
using Introduction.Interfaces;

namespace Introduction.Services
{
    public class CoffeeService : ISingletonCoffee , ITransientCoffee , IScopedCoffee
    {
        private readonly string _coffeeId;
        public CoffeeService()
        {
            _coffeeId = Guid.NewGuid().ToString();
        }
        public string GetCoffeeId()
        {
            return _coffeeId;
        }
    }
}
