using Microsoft.AspNetCore.Mvc;

using Introduction.Interfaces;

namespace Introduction.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CoffeeShopController : ControllerBase
    {


        // Raju , bhanu   // Singleton

            private  ISingletonCoffee _singletonCoffee1;
            private  ISingletonCoffee _singletonCoffee2;


            private IScopedCoffee _scopedCoffee1;
            private IScopedCoffee _scopedCoffee2;


            private ITransientCoffee _tranientCoffee1;
            private ITransientCoffee _tranientCoffee2;
        


        public CoffeeShopController(
            ISingletonCoffee singleton1 ,
            ISingletonCoffee singleton2 ,
            IScopedCoffee scopedCoffee1 ,
            IScopedCoffee scopedCoffee2,
            ITransientCoffee tranientCoffee1,
            ITransientCoffee tranientCoffee2
            )
        {
            _singletonCoffee1 = singleton1;
            _singletonCoffee2 = singleton2;


            _scopedCoffee1 = scopedCoffee1;
            _scopedCoffee2 = scopedCoffee2;


            _tranientCoffee1 = tranientCoffee1;
            _tranientCoffee2 = tranientCoffee2;
        }



        [HttpGet]
        [Route("GetCoffee")]

        //Endpoint : https:localhost:7246/api/CoffeeShop/GetCoffee

        public IActionResult GetCoffee()
        {

            var SingletonResult = new CoffeType()
            {
                cup1 = _singletonCoffee1.GetCoffeeId(),   //Raju
                cup2 = _singletonCoffee2.GetCoffeeId()    //Bhanu
            };



            var ScopedResult = new CoffeType()
            {
                cup1 = _scopedCoffee1.GetCoffeeId(),   //Raju
                cup2 = _scopedCoffee2.GetCoffeeId()    //Bhanu
            };


            var TransientResult = new CoffeType()
            {
                cup1 = _tranientCoffee1.GetCoffeeId(),   //Raju
                cup2 = _tranientCoffee2.GetCoffeeId()    //Bhanu
            };





            var FinalResult = new
            {
                Singleton = SingletonResult,
                Scoped    = ScopedResult,
                Transient = TransientResult
            };

            return Ok(FinalResult);
        }




    }




    public class CoffeType
    {
         public string cup1 {  get; set; }  

         public string cup2 {  get; set; }
    }



}
