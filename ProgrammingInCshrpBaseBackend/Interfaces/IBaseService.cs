namespace ProgrammingInCshrpBaseBackend.Interfaces;

//Generic --> Type --> <T> :independet to Type of Data, therefor, we need "interface"
public interface IBaseService<T>
{
    //all this Methods are "public", otherwise it doesn't make sense
    void Update(T item); 
    void Delete(int  id);
    void Add(T item);
    List<T> GetAll();
}
