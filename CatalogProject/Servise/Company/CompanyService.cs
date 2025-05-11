using CatalogProject.Global;
using LiteDB;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using CatalogProject.Servise.Category;

namespace CatalogProject.Servise.Company;

public interface ICompanyService
{
    int FindNextId();

    List<Models.Company> GetAllCompanies();
    IEnumerable<Models.Company> GetOptionsByFilter(string parameter);
    Models.Company GetCompaniesById(int companyId);
    bool InsertCompany(Models.Company company);
    bool UpdateCompany(Models.Company company);
    bool DeleteCompany(Models.Company company);
    bool DeleteCompany(int companyId);

}
public class CompanyService: ICompanyService
{

    private readonly ILiteCollection<Models.Company> _collection;

    public CompanyService(DatabaseContext dbContext)
    {
        _collection = dbContext.Companies;
    }


    public int FindNextId()
    {
        int nextId = (_collection.Query().OrderByDescending(x => x.Id).FirstOrDefault()?.Id ?? 0) + 1;
        return nextId;
    }

    public List<Models.Company> GetAllCompanies()
    {
      return  _collection.FindAll().ToList();
    }

    public IEnumerable<Models.Company> GetOptionsByFilter(string parameter)
    {
       return _collection.Find(x => x.Name == parameter);
    }

    public Models.Company GetCompaniesById(int companyId)
    {
        return _collection.FindById(companyId);
    }

    public bool InsertCompany(Models.Company company)
    {
        try
        {
            var newId = FindNextId();
            company.Id = newId;
          _collection.Insert(new BsonValue(newId), company);
            return true;
        }
        catch (InvalidCastException)
        {
            // Log if needed
            return false;
        }
    }

    public bool UpdateCompany(Models.Company company)
    {
       return _collection.Update(company);
    }

    public bool DeleteCompany(Models.Company company)
    {
        return _collection.Delete(company.Id);
    }

    public bool DeleteCompany(int companyId)
    {
        return _collection.Delete(companyId);
    }

   

 
}