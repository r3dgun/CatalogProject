using System.IO;
using System.Windows.Forms;
using System;
using System.Drawing;

namespace CatalogProject.Servise.helper;

public static class Helper
{
    public static Image LoadImageFromPath(string imagePath,string imageName)
    {
        if (string.IsNullOrEmpty(imageName))
        {
            return null;
        }
        var imageAddress = Path.Combine(imagePath, imageName);
        if (File.Exists(imageAddress))
        {
            return Image.FromFile(imageAddress);
        }
        return null;
    }
    public static Image LoadImageFromPath(string imageAddress)
    {
        if (File.Exists(imageAddress))
        {
            return Image.FromFile(imageAddress);
        }
        return null;
    }
    public static string SaveFileToDirectoryAndGetImageName(string selectedImagePath ,string saveDirectory)
    {
        if (selectedImagePath == null) return null;

        try
        {
            // بررسی و ایجاد دایرکتوری در صورت عدم وجود
            if (!Directory.Exists(saveDirectory))
            {
                Directory.CreateDirectory(saveDirectory);
            }

            // دریافت پسوند فایل
            string fileExtension = Path.GetExtension(selectedImagePath);

            // نام جدید بر اساس GUID
            string newFileName = Guid.NewGuid().ToString() + fileExtension;

            // مسیر نهایی ذخیره‌سازی
            string savePath = Path.Combine(saveDirectory, newFileName);

            // کپی فایل
            File.Copy(selectedImagePath, savePath, true);

            return newFileName;
        }
        catch (Exception ex)
        {
            // مدیریت خطا (می‌توانید لاگ کنید یا مقدار خاصی برگردانید)
            Console.WriteLine("خطا در ذخیره‌سازی تصویر: " + ex.Message);
            return null;
        }
    }
}