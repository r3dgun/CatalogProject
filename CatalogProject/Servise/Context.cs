using LiteDB;
using Models;
using System;
using CatalogProject.Global;

namespace CatalogProject.Servise;

public class DatabaseContext : IDisposable
{
    private readonly LiteDatabase _db;
    private bool _disposed;

    public DatabaseContext()
    {
        _db = new LiteDatabase(GlobalSetting.DataBaseName);
    }

    public ILiteCollection<Models.Company> Companies => _db.GetCollection<Models.Company>("companies");
    public ILiteCollection<Models.Category> Categories => _db.GetCollection<Models.Category>("categories");
    public ILiteCollection<Models.Product> Products => _db.GetCollection<Models.Product>("products");
    public ILiteCollection<Models.Option> Options => _db.GetCollection<Models.Option>("options");
    public ILiteCollection<Models.Theme> Themes => _db.GetCollection<Models.Theme>("Themes");
    public ILiteCollection<Models.Font> Fonts => _db.GetCollection<Models.Font>("Fonts");


    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (_disposed) return;

        if (disposing && _db != null)
        {
            _db.Dispose();
        }

        _disposed = true;
    }
}