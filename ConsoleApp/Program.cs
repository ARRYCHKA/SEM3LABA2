using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BusinessLogic;
using Model;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logic logic = new Logic();
            int choice;
            do
            {
                Console.WriteLine("Выберите пункт:");
                Console.WriteLine("1. Добавление ");
                Console.WriteLine("2. Удаление");
                Console.WriteLine("3. Чтение");
                Console.WriteLine("4. Изменение");
                Console.WriteLine("5. Поиск по цвету");
                Console.WriteLine("6. Поиск по году");
                Console.WriteLine("7. Выход");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                
                {
                    case 1:
                        AddCars(logic);
                        break;
                    case 2:
                        RemoveCar(logic);
                        break;
                    case 3:
                        ReadCars(logic);
                        break;
                    case 4:
                        UpdateCars(logic);
                        break;
                    case 5:
                        FindCarByColor(logic);
                        break;
                    case 6:
                        FindCarByYear(logic);
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                } 
            } while (choice != 7) ;
        }
        /// <summary>
        /// Метод для добавление автомобилей
        /// </summary>
        /// <param name="logic"></param>
        static void AddCars(Logic logic)
        {
            Console.WriteLine("Введите id машины");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите бренд машины");
            string brand = Console.ReadLine();
            Console.WriteLine("Введите цвет машины");
            string color = Console.ReadLine();
            Console.WriteLine("Введите год производства машины:");
            string year =Console.ReadLine();
            try { logic.AddCars(id, brand, color, year); }
            catch
            {
                Console.WriteLine("ОШИБКА! ПОПРОБУЙ ЕЩЕ РАЗ!");
                return;
            }
            Console.WriteLine("Машина добавлен.");
        }
        /// <summary>
        /// Метод для удаления автомобиля из списка
        /// </summary>
        /// <param name="logic"></param>
        static void RemoveCar(Logic logic)
        {
            if (logic.GetAllCars().Count == 0)
            {
                Console.WriteLine("Список машин пуст!");
                return;
            }
            else
            {
                foreach (var car in logic.GetAllCars())
                {
                    Console.WriteLine($" ID: { car[0]}, Бранд :{car[1]}, Цвет:  {car[2]}, Год: {car[3]}");

                }
                Console.Write("Введите id машины для удаления: \n");
                int chosenID;
                if(!int.TryParse(Console.ReadLine(), out chosenID))
                {
                    Console.WriteLine("ОШИБКА!");
                    return;
                }             
                
                try
                {
                    logic.RemoveCar(chosenID);
                    Console.WriteLine("Автомобиль удален.");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch
                {
                    Console.WriteLine("Ошибка!");
                }                
            }
        }
        /// <summary>
        /// Метод для чтения списка автомобилей
        /// </summary>
        /// <param name="logic"></param>
        static void ReadCars(Logic logic)
        {
            Console.WriteLine("Список машин:");
            if (logic.GetAllCars().Count > 0)
            {
                foreach (var car in logic.GetAllCars())
                {
                    Console.WriteLine($"Бранд :{car[1]}, Цвет:  {car[2]}, Год: {car[3]}");
                }
            }
            else
            {
                Console.WriteLine("Список пуст!");
            }
        }
        /// <summary>
        /// Метод для изменения данных автомобиля 
        /// </summary>
        /// <param name="logic"></param>
        static void UpdateCars(Logic logic)
        {
            Console.WriteLine("Выберите id машины для изменения:");
            if (logic.GetAllCars().Count == 0)
            {
                Console.WriteLine("Список машин пуст!");
                return;
            }
            else
            {
                
                foreach (var car in logic.GetAllCars())
                {
                    Console.WriteLine($"ID:{car[0]} Бренд:{car[1]} Цвет:{car[2]} Год:{car[3]}");
                    
                }
                int chosenID;
                if (!int.TryParse(Console.ReadLine(), out chosenID))
                {
                    Console.WriteLine("");
                    return;
                }
                Console.Write("Введите новый бренд: ");
                string brand = Console.ReadLine();

                Console.Write("Введите новый цвет: ");
                string color = Console.ReadLine();

                Console.Write("Введите новый год производства: ");
                string year = Console.ReadLine(); 

                if (brand == string.Empty || color == string.Empty || year == string.Empty)
                {
                    Console.WriteLine("Автомобиль обновлен");
                    return;
                }
                try
                {
                    logic.UpdateCars(chosenID, brand, color, year);
                    Console.WriteLine("Ошибочка");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch
                {
                    Console.WriteLine("Ошибочка");
                }               
            }
        }
        /// <summary>
        /// Поиск автомобиля по году
        /// </summary>
        /// <param name="logic"></param>
        static void FindCarByYear(Logic logic)
        {
            Console.Write("Введите год для поиска: ");
            string year = Console.ReadLine();
            List<Car> cars = logic.FindCarByYear(year);
            foreach (var car in cars)
            {
                Console.WriteLine($"Бренд: {car.Brand}, Цвет: {car.Color}, ГОд: {car.Year}");
            }
        }
        /// <summary>
        /// Поиск автомобиля по цвету
        /// </summary>
        /// <param name="logic"></param>
        static void FindCarByColor(Logic logic)
        {
            Console.Write("Введите цвет для поиска: ");
            string color= Console.ReadLine();
            List<Car> cars = logic.FindCarByColor(color);
            foreach (var car in cars)
            {
                Console.WriteLine($"Бренд: {car.Brand}, Цвет: {car.Color}, ГОд: {car.Year}");
            }
        }
    }
}
