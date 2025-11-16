using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IRepository<T> : IDisposable where T : class
    {
        // Добавление нового объекта
        void Add(T entity);

        // Удаление объекта по идентификатору
        void Delete(int id);

        // Получение всех объектов
        IEnumerable<T> ReadAll();

        // Получение объекта по идентификатору
        T ReadById(int id);

        // Обновление объекта
        void Update(T entity);
    }
}
