using System;
using CatalogProject.Global;
using LiteDB;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace CatalogProject.Servise.Category;
public interface ICompanyService
{
    int FindNextId();
    List<Models.Category> GetAllCategories();
    IEnumerable<Models.Category> GetCategoriesByFilter(string parameter);
    Models.Category GetCategoryById(int categoryId);
    int InsertCategory(Models.Category category);
    bool UpdateCategory(Models.Category category);
    bool DeleteCategory(Models.Category category);
    bool DeleteCategory(int categoryId);
    List<Models.Category> GetCategoriesWithCompanyId(int companyId);

    string GetCategoriesNameWithCompanyId(int companyId);
    bool DeleteCategoriesWithCompanyId(int companyId);

}
public class CategoryService: ICompanyService
{
    private readonly ILiteCollection<Models.Category> _collection;

    public CategoryService()
    {
        _collection = DatabaseContext.Instance.Categories;
    }

    public int FindNextId()
    {
        int nextId = (_collection.Query().OrderByDescending(x => x.Id).FirstOrDefault()?.Id ?? 0) + 1;
        return nextId;
    }
    public List<Models.Category> GetAllCategories()
    {
        return _collection.FindAll().ToList();
    }

    public IEnumerable<Models.Category> GetCategoriesByFilter(string parameter)
    {
        return _collection.Find(x=>x.Name == parameter);

    }

    public Models.Category GetCategoryById(int categoryId)
    {
        return _collection.FindById(categoryId);
    }

    public int InsertCategory(Models.Category category)
    {
        try
        {
            var newId = FindNextId();
            category.Id = newId;
            _collection.Insert(new BsonValue(newId), category);
            return category.Id;
        }
        catch (InvalidCastException)
        {
            // Log if needed
            return 0;
        }
    }

    public bool UpdateCategory(Models.Category category)
    {
      return _collection.Update(category);
    }

    public bool DeleteCategory(Models.Category category)
    {
       return _collection.Delete(category.Id);
    }

    public bool DeleteCategory(int categoryId)
    {
      return  _collection.Delete(categoryId);
    }

  

    public List<Models.Category> GetCategoriesWithCompanyId(int companyId)
    {
        var categories = _collection.Find(c => c.CompanyId == companyId).ToList();
        return categories;
    }

    public string GetCategoriesNameWithCompanyId(int companyId)
    {
        var names = GetCategoriesWithCompanyId(companyId).Select(c => c.Name);
       return string.Join(",", names);
    }

    public bool DeleteCategoriesWithCompanyId(int companyId)
    {
        try
        {
            var categories = GetCategoriesWithCompanyId(companyId);
            foreach (var category in categories)
            {
                DeleteCategory(category);
            }
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }
}