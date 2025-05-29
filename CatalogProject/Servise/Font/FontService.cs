using LiteDB;
using Models;
using System;
using System.Linq;

namespace CatalogProject.Servise.Font;

public interface IFontService
{
    int FindNextId();
    Models.Font GetThemeById(int themeFontId);
    int InsertFont(Models.Font font);
    bool UpdateFont(Models.Font font);
    Models.Font GetThemeFontWithDetail(FormName formName, FontPart fontPart);
    bool SaveFont(Models.Font font);

}
public class FontService : IFontService
{
    private readonly ILiteCollection<Models.Font> _collection;

    public FontService(DatabaseContext dbContext)
    {
        _collection = dbContext.Fonts;
    }

    public int FindNextId()
    {
        int nextId = (_collection.Query().OrderByDescending(x => x.Id).FirstOrDefault()?.Id ?? 0) + 1;
        return nextId;
    }

    public Models.Font GetThemeById(int themeFontId)
    {
        return _collection.FindById(themeFontId);
    }

    public int InsertFont(Models.Font font)
    {
        try
        {
            var newId = FindNextId();
            font.Id = newId;
            _collection.Insert(new BsonValue(newId), font);
            return font.Id;
        }
        catch (InvalidCastException)
        {
            // Log if needed
            return 0;
        }
    }

    public bool UpdateFont(Models.Font font)
    {
        return _collection.Update(font);
    }

    public Models.Font GetThemeFontWithDetail(FormName formName ,FontPart fontPart)
    {
        return _collection.Find(t => t.FontPart == fontPart && t.FormName== formName).FirstOrDefault();
    }

    public bool SaveFont(Models.Font font)
    {
        try
        {
            var temp = GetThemeFontWithDetail(font.FormName, font.FontPart);

            if (temp!=null)
            {
                font.Id = temp.Id;
                UpdateFont(font);
            }
            else
            {
                InsertFont(font);
            }
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }
}