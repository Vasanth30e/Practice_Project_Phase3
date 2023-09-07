using NPOI.SS.Formula.Functions;

namespace Phase3Section2._32.Repository
{
    public interface IGenericRepository<t> where t : class
    {
        IEnumerable<t> SelectAll();
        T SelectByID(object id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        void Save();
    }
}

