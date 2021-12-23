using System.Collections.Generic;

namespace ExcelImport.Persistance
{
    public interface IRepository<T>
    {
        void Create();

        IList<T> ReadAll();

        T FindById(int id);

        void Update(T record);

        void Delete(T record);
    }
}
