using System;
using LiteDB;
using System.Collections.Generic;
using System.Linq;

namespace CatalogProject.Servise.Option;

public interface IOptionService
{

    int FindNextId();
    List<Models.Option> GetAllOptions();
    IEnumerable<Models.Option> GetOptionsByFilter(string parameter);
    Models.Option GetOptionsById(int optionId);
    int InsertOption(Models.Option option);
    List<int> InsertOptions(List<Models.Option> options);
    bool UpdateOption(Models.Option option);
    bool DeleteOption(Models.Option option);
    bool DeleteOption(int optionId);
    List<Models.Option> GetProductsOptions(int productId);
    string GetProductsOptionsName(int productId);
    bool DeleteProductOptions(int productId);

}
public class OptionService : IOptionService
{
    private readonly ILiteCollection<Models.Option> _collection;

    public OptionService(DatabaseContext dbContext)
    {
        _collection = dbContext.Options;
    }

    public int FindNextId()
    {
        int nextId = (_collection.Query().OrderByDescending(x => x.Id).FirstOrDefault()?.Id ?? 0) + 1;
        return nextId;
    }

    public List<Models.Option> GetAllOptions()
    {
        return _collection.FindAll().ToList();
    }

    public IEnumerable<Models.Option> GetOptionsByFilter(string parameter)
    {
        if (string.IsNullOrEmpty(parameter))
            return GetAllOptions();

        return _collection.Find(x => x.Name.Contains(parameter));
    }

    public Models.Option GetOptionsById(int optionId)
    {
        return _collection.FindById(optionId);
    }

    public int InsertOption(Models.Option option)
    {
        if (option == null)
            return 0;
        try
        {
            var newId = FindNextId();
            option.Id = newId;
            _collection.Insert(new BsonValue(newId), option);
            return option.Id;
        }
        catch (InvalidCastException)
        {
            // Log if needed
            return 0;
        }
    }

    public List<int> InsertOptions(List<Models.Option> options)
    {
        List<int> ids = new List<int>();
        foreach (var option in options)
        {
            ids.Add(InsertOption(option));
        }
        return ids;
    }

    public bool UpdateOption(Models.Option option)
    {
        if (option == null)
            return false;

        return _collection.Update(option);
    }

    public bool DeleteOption(Models.Option option)
    {
        return option != null && DeleteOption(option.Id);
    }

    public bool DeleteOption(int optionId)
    {
        return _collection.Delete(optionId);
    }

    public List<Models.Option> GetProductsOptions(int productId)
    {
        return _collection.Find(p => p.ProductId == productId).ToList();
    }

    public string GetProductsOptionsName(int productId)
    {
        var options = GetProductsOptions(productId).Select(o => o.Name).ToList();

        return string.Join(",", options);
    }

    public bool DeleteProductOptions(int productId)
    {
        var options = GetProductsOptions(productId);
        try
        {
            foreach (var option in options)
            {
                DeleteOption(option);
            }
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
        
    }

  

}