using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

ISaloonDal saloonDal = new DataAccess.Concrete.EntityFramework.SaloonDal();
SaloonManager salonService = new SaloonManager(saloonDal);

Salon salon = new Salon
{
    Id  = 1,
    Name = "Salon Nazmi",
    Description = "Premium Hizmet Noktası",
    TaxNumber = "1234567890",
    Email = "nazmi@gmail.com",
    IsActive = true
    };
salonService.Add(salon);

var salons = salonService.GetAll();

Console.WriteLine(salons.Data.Count);


Console.ReadLine();
