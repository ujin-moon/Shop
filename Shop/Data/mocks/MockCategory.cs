using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.mox
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>()
                {
                    new Category{categoryName = "Седан", desc = "Классический и удобный тип кузова для комфортной езды по городу и трассе" },
                    new Category{categoryName = "Хэтчбек", desc = "Компактный и удобный для парковки в городе тип кузова с удобным доступом к багажнику" },
                    new Category{categoryName = "Кроссовер", desc = "Высокий и вместительный кузов, отлично подходит для поездок по бездорожью или для больших семей" },
                    new Category{categoryName = "Универсал", desc = "Просторный и удобный для путешествий, идеальный выбор для больших семей или поездок с большим количеством багажа" },
                    new Category{categoryName = "Купе", desc = "Стильный и спортивный тип кузова, созданный для быстрой и динамичной езды" },
                    new Category{categoryName = "Кабриолет", desc = "Романтичный и легкий тип кузова, отлично подходит для круизов по городу в теплое время года" }
                };
            }
        }
    }
}
