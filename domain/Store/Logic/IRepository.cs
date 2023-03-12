using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Logic
{
    public interface IRepository<T> : IDisposable where T : class
    {
        IEnumerable<T> GetAllItem();
        T? GetItemById(int id);
        bool Create(T item);
        bool Update(T item);
        bool Delete(T item);
        void Save();
    }
}
