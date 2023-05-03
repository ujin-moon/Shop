using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.Data.mox;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {

        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car {
                        Name = "Audi А4",
                        shortDesc = "Лучший в своем деле",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "https://avatars.mds.yandex.net/get-verba/787013/2a0000016b7e65c13c5acad18b2101595da2/cattouch",
                        price = 60,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car {
                        Name = "Volvo V40",
                        shortDesc = "Бесшумный и экономный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/57/Volvo_V40_2012_ID42221_280212.jpg/1024px-Volvo_V40_2012_ID42221_280212.jpg",
                        price = 25,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Skip(1).First()
                    },
                    new Car {
                        Name = "Volvo XC60",
                        shortDesc = "Уютный и большой",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "https://wroom.ru/i/cars2/volvo_xc60_2.jpg",
                        price = 80,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Skip(2).First()
                    },
                    new Car {
                        Name = "BMW E39",
                        shortDesc = "Вместительный автомобиль",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "https://s.auto.drom.ru/i24198/c/photos/fullsize/bmw/5-series/bmw_5-series_535847.jpg",
                        price = 20,
                        isFavourite = false,
                        available = false,
                        Category = _categoryCars.AllCategories.Skip(3).First()
                    },
                    new Car {
                        Name = "Toyota GR 86",
                        shortDesc = "Быстрый автомобиль",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "https://autoreview.ru/images/Article/1719/Article_171959_860_575.jpg",
                        price = 95,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Skip(4).First()
                    },
                    new Car {
                        Name = "Volswagen Golf",
                        shortDesc = "Элегантный и заметный автомобиль",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "https://uploads.vw-mms.de/system/production/images/vwn/011/346/images/998af3d2bbcfea196942d5254049f1a6019d583f/DB2011AU00440_web_1600.jpg?1649148277",
                        price = 35,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                };
            }
        }
        public IEnumerable<Car> getFavCars { get ; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
