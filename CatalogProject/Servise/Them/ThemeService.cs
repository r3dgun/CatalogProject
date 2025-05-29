using LiteDB;
using System.Collections.Generic;
using Models;
using System;
using System.Linq;

namespace CatalogProject.Servise.Them;
public interface IThemeService
{
    int FindNextId();
    Models.Theme GetThemeById(int themeColorsId);
    int InsertTheme(Models.Theme theme);
    bool SaveThemeColors(Models.Theme theme);
    Theme GetThemeColorsWithName(string formName);





}
public class ThemeService : IThemeService
{
    private readonly ILiteCollection<Models.Theme> _collection;

    public ThemeService(DatabaseContext dbContext)
    {
        _collection = dbContext.Themes;
    }

    public int FindNextId()
    {
        int nextId = (_collection.Query().OrderByDescending(x => x.Id).FirstOrDefault()?.Id ?? 0) + 1;
        return nextId;
    }

    public Theme GetThemeById(int themeColorsId)
    {
        return _collection.FindById(themeColorsId);
    }

    public int InsertTheme(Theme theme)
    {
        try
        {
            var newId = FindNextId();
            theme.Id = newId;
            _collection.Insert(theme);
            return theme.Id;
        }
        catch (InvalidCastException)
        {
            // Log if needed
            return 0;
        }
    }

    public bool SaveThemeColors(Theme theme)
    {
        try
        {
            var temp = GetThemeColorsWithName(theme.FormName);
            if (temp != null)
            {
                theme.Id = temp.Id;
                return _collection.Update(theme);
            }
            else
            {
                InsertTheme(theme);
            }
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }


    public Theme? GetThemeColorsWithName(string formName)
    {
        var themeColors = _collection.Find(t => t.FormName == formName);
        return themeColors.FirstOrDefault(); // This is redundant but explicit
    }


}