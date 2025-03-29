using LiteDB;
using Models;
using System;
using CatalogProject.Global;

namespace CatalogProject.Servise;

public class DatabaseContext : IDisposable
{
    private static readonly Lazy<DatabaseContext> _instance = new Lazy<DatabaseContext>(() => new DatabaseContext());
    private static readonly Lazy<LiteDatabase> _lazyDb = new(() => new LiteDatabase(GlobalSetting.DataBaseName));
    private readonly LiteDatabase _db;
    private bool _disposed;

    // Private constructor to prevent direct instantiation
    private DatabaseContext()
    {
        _db = _lazyDb.Value;
    }

    // Public property to access the singleton instance
    public static DatabaseContext Instance => _instance.Value;

    public ILiteCollection<Models.Company> Companies => _db.GetCollection<Models.Company>("companies");
    public ILiteCollection<Models.Category> Categories => _db.GetCollection<Models.Category>("categories");
    public ILiteCollection<Models.Product> Products => _db.GetCollection<Models.Product>("products");
    public ILiteCollection<Models.Option> Options => _db.GetCollection<Models.Option>("options");

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