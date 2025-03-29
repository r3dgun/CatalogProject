using LiteDB;
using System.Collections.Generic;

namespace CatalogProject.Servise.CrudService;

public class CRUDService<T>
{
    private readonly ILiteCollection<T> _collection;

    public CRUDService(ILiteCollection<T> collection)
    {
        _collection = collection;
    }

    public void Create(T entity) => _collection.Insert(entity);
    public IEnumerable<T> ReadAll() => _collection.FindAll();
    public T Read(int id) => _collection.FindById(id);
    public bool Update(T entity) => _collection.Update(entity);
    public bool Delete(int id) => _collection.Delete(id);
}
