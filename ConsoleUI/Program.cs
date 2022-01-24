using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI

//SOLID
//O: Open Closed Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

             customerManager.Add(new Customer {
             CompanyName="Company"
             });
            

            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User
            {
                Email = "company@hotmail.com",
                FirstName = "Kaan",
                LastName="Varışlı",
                Password="123456",
                UserId=1
                
            }) ; 
            


            // CarTest();

            //BrandTest();

            //ColorTest();
        }
    


        private static void CarTest()
        {
            Car myCar = new Car
            {
                BrandId = 4,
                ColorId = 3,
                ModelYear = "2020",
                DailyPrice = 800,
                Description = "Volvo "
            };

            CarManager carManager = new CarManager(new EfCarDal());

            //carManager.Add(myCar);   //..Commented because always adding and adding..

            var result = carManager.GetCarDetails();

            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(
                               "Car's Description: " + item.CarName + " \n" +
                               "Car's Brand Name: " + item.BrandName + " \n" +
                               "Car's Color: " + item.ColorName + " \n" +
                               "Car's Daily Price: " + item.DailyPrice + " \n" +
                               "******************************************"
                        );
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.Name);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.Name);
            }
        }
    }
}
