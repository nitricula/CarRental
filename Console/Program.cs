using Business.Concrete;

using Entities.Concrete;
using Repositories.Concrete.EntityFramework;
using Repositories.Concrete.IMem;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //InMemTest();
            // EntityTest();

            //BrandTest();

            //ColorTest();
            //ExceptionCheck();

            //CarDetailTest();

            //UserTest();

            //CustomerTest();

            RentTest();
        }

        private static void RentTest()
        {
            var rentalService = new RentalService(new EfRentalDal());

            rentalService.Add(new Rental { CarId=1,CustomerId = 1, RentDate = new DateTime(1920, 6, 14) });
            rentalService.Add(new Rental { CarId=1003,CustomerId = 2, RentDate = DateTime.Now });
            var result = rentalService.GetAll();
            foreach (var item in result.Data)
            {
                System.Console.WriteLine(item.RentDate);
            }
        }

        private static void CustomerTest()
        {
            var customerService = new CustomerService(new EfCustomerDal());
            customerService.Add(new Customer { UserId = 1, CompanyName = "Murat Aş" });
            customerService.Add(new Customer { UserId = 3, CompanyName = "Bulut İnşaat" });

            var result = customerService.GetAll();
            foreach (var item in result.Data)
            {
                System.Console.WriteLine(item.CompanyName);
            }
        }

        private static void UserTest()
        {
            var userService = new UserService(new EfUserDal());

            userService.Add(new User
            {
                FirstName = "Murat",
                LastName = "Hıdır",
                Password = Encoding.UTF8.GetBytes("m3271669")
            });
            userService.Add(new User
            {
                FirstName = "Hıdır",
                LastName = "Hakkı",
                Password = Encoding.UTF8.GetBytes("+m3271669-")
            });
            userService.Add(new User
            {
                FirstName = "Bulut",
                LastName = "Nadir",
                Password = Encoding.UTF8.GetBytes("12345")
            });

            var result = userService.GetAll();
            foreach (var item in result.Data)
            {
                System.Console.WriteLine(item.FirstName + "  " + item.LastName);
            }
        }

        private static void CarDetailTest()
        {
            var carService = new CarService(new EfCarDal());

            var result = carService.GetCarDetailDtos();

            foreach (var item in result)
            {
                System.Console.WriteLine(item.CarName + "  " + item.BrandName + "  " + item.ColorName + "  " + item.DailyPrice);
            }
        }

        private static void ExceptionCheck()
        {
            var carService = new CarService(new EfCarDal());
            carService.Add(new Car { BrandId = 1, Name = "Ali", ColorId = 1, DailyPrice = 0, Description = "Test", ModelYear = 1975 });
            carService.Add(new Car { BrandId = 1, Name = "A", ColorId = 1, DailyPrice = 3, Description = "Test", ModelYear = 1975 });
        }

        private static void ColorTest()
        {
            var colorService = new ColorService(new EfColorDal());



            colorService.Add(new Color { Name = "Siyah" });
            colorService.Add(new Color { Name = "Turuncu" });
            colorService.Add(new Color { Name = "Beyaz" });
            colorService.Add(new Color { Name = "Sarı" });

            var result = colorService.GetAll();

            foreach (var item in result.Data)
            {
                System.Console.WriteLine(item.Name);
            }
        }

        private static void BrandTest()
        {
            var brandService = new BrandService(new EfBrandDal());

            //brandService.Add(new Brand { Name = "Toyota" });
            //brandService.Add(new Brand { Name = "Mazda" });
            //brandService.Add(new Brand { Name = "Mercedes" });

            var result = brandService.GetAll();

            foreach (var item in result.Data)
            {
                System.Console.WriteLine(item.Name);
            }
        }

        private static void EntityTest()
        {
            var carService = new CarService(new EfCarDal());

            //carService.Add(new Car { BrandId = 1, ColorId = 1, DailyPrice = 17.25f, Description = "Test", ModelYear = 1975 });
            //var result = carService.Get(c => c.Description == "Test");
            //result.Description = "UpdatedTest";
            //carService.Update(result);
            //result = carService.Get(c => c.Description == "UpdatedTest");


            //carService.Delete(carService.Get(c=>c.Id==1002));
            //System.Console.WriteLine(result.Description);
            var result = carService.GetAll();
            foreach (var item in result.Data)
            {
                System.Console.WriteLine(item.Description);
            }
        }

        private static void InMemTest()
        {
            var carService = new CarService(new CarDal(new List<Car>()));
            var car1 = new Car { BrandId = 1, ColorId = 1, DailyPrice = 17.25f, Description = "", Id = 1, ModelYear = 1975 };
            var car2 = new Car { BrandId = 2, ColorId = 2, DailyPrice = 17.25f, Description = "", Id = 2, ModelYear = 1975 };
            var car3 = new Car { BrandId = 3, ColorId = 3, DailyPrice = 17.25f, Description = "", Id = 3, ModelYear = 1975 };
            carService.Add(car1);
            carService.Add(car2);
            carService.Add(car3);
            foreach (var item in carService.GetAll().Data)
            {
                System.Console.WriteLine(item.Id);
            }
            carService.Delete(car2);
            foreach (var item in carService.GetAll().Data)
            {
                System.Console.WriteLine(item.Id);
            }
        }
    }
}
