
using Model;
using static System.Reflection.Metadata.BlobBuilder;

namespace BusinessLogic
{
    public  class Logic
    {
        private List<Car> cars = new List<Car>();
        /// <summary>
        /// Бизнес логика для добавления автомобиля
        /// </summary>
        /// <param name="id"></param>
        /// <param name="brand"></param>
        /// <param name="color"></param>
        /// <param name="year"></param>
        /// <exception cref="ArgumentException"></exception>
        public void AddCars(int id, string brand, string color, string year)
        {
            if (brand == string.Empty || color == string.Empty || year ==string.Empty) { throw new ArgumentException("Все поля должны быть заполнены!"); }
            if (cars.Any(car=>car.Id ==id))
            {
                throw new ArgumentException("Автомобиль с таким id уже существует!");
            }
            else
            {
                Car newCar = new Car(id, brand, color, year);
                cars.Add(newCar);
            }
        }
        /// <summary>
        /// Списк автомобилей
        /// </summary>
        /// <returns></returns>
        public List<List<string>> GetAllCars()
        {
            List<List<string>> finallist = new List<List<string>>();
            foreach (var car in cars)
            {
                List<string> carList = new List<string>
                {
                    car.Id.ToString(),
                    car.Brand,
                    car.Color,
                    car.Year,
                };
                finallist.Add(carList);
            }
            return finallist;
        }
        /// <summary>
        /// Удаление автомобиля
        /// </summary>
        /// <param name="id"></param>
        /// <exception cref="ArgumentException"></exception>
        public void RemoveCar(int id)
        {
            var carToRemove = cars.Find(c => c.Id == id);
            if (carToRemove != null)
            {
                cars.Remove(carToRemove);
            }
            else
            {
                throw new ArgumentException("Автомобиль с таким id не найден.");
            }
        }
        /// <summary>
        /// Изменение для автомобиля
        /// </summary>
        /// <param name="id"></param>
        /// <param name="newBrand"></param>
        /// <param name="newColor"></param>
        /// <param name="newYear"></param>
        /// <exception cref="ArgumentException"></exception>
        public void UpdateCars(int id, string newBrand, string newColor, string newYear)
        {
            var carToUpdate = cars.Find(c => c.Id == id);
            if (carToUpdate != null)
            {
                if (!string.IsNullOrEmpty(newBrand))
                {
                    carToUpdate.Brand = newBrand;
                }
                if (!string.IsNullOrEmpty(newColor))
                {
                    carToUpdate.Color = newColor;
                }
                if (!string.IsNullOrEmpty(newYear))
                {
                    carToUpdate.Year = newYear;
                }
            }
            else
            {
                throw new ArgumentException("Автомобиль с указанным ID не найден");
            }
        }
        /// <summary>
        /// Поиск по году
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public List<Car> FindCarByYear(string year)
        {
            return cars.FindAll(b => b.Year == year);
        }
        /// <summary>
        /// Поиск по цвету
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public List<Car> FindCarByColor(string color)
        {
            return cars.FindAll(b => b.Color == color);
        }
        /// <summary>
        /// Поиск по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Car FindCarByID(int id)
        {
            return cars.Find(b => b.Id == id);
        }


    }
}
