

namespace ProgrammingInCshrpBaseBackend.Interfaces
{
    //Generic --> Type --> <T> :undependet to Type of Data, therfore, we need "interface"
    public interface IBaseService<T>
    {
        void Update(T item);
        void Delete(int  id);
        void Add(T item);

        List<T> GetAll();
        
    }
}
