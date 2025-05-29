using System.IO;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using Bunifu.UI.WinForms.BunifuAnimatorNS;
using static CatalogProject.Servise.helper.Helper;

namespace CatalogProject.Servise.helper;

public static class Helper
{
    public enum PathName 
    {
        CategoryImage,
        CompanyImage,
        ProductImage,
        BGImage

    }
    public static Image LoadImageFromPath(string imageName,PathName pathName)
    {

        var imagePath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), pathName.ToString());
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
    public static string SaveFileToDirectoryAndGetImageName(string selectedImagePath, PathName pathName)
    {
        var saveDirectory = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), pathName.ToString());
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
    public static List<Animation> GetRandomAnimations()
    {
        List<Animation> allAnimations = new List<Animation>
        {
            Animation.Particles,
            Animation.HorizSlideAndRotate,
            Animation.HorizBlind,
            Animation.Leaf,
            Animation.Mosaic,
            Animation.Rotate,
            Animation.Transparent,
            Animation.VertBlind,
            Animation.VertSlide,
            Animation.HorizSlide,
            Animation.Scale,
            Animation.ScaleAndRotate,
            Animation.ScaleAndHorizSlide,
            // می‌توانید انیمیشن‌های دیگری را اضافه کنید
        };
        // لیست تمامی انیمیشن‌ها را دریافت می‌کنیم
        Random random = new Random();
        List<Animation> randomAnimations = new List<Animation>();

        // اگر تعداد انیمیشن‌ها بیشتر از 4 باشد
        while (randomAnimations.Count < 4)
        {
            Animation selectedAnimation = allAnimations[random.Next(allAnimations.Count)];

            // اگر انیمیشن انتخاب‌شده قبلاً انتخاب نشده باشد، آن را اضافه می‌کنیم
            if (!randomAnimations.Contains(selectedAnimation))
            {
                randomAnimations.Add(selectedAnimation);
            }
        }

        return randomAnimations;
    }
    public static DateTime ConvertMiladiToShamsi(this DateTime dateTime)
    {
        PersianCalendar calendar = new PersianCalendar();
        return new DateTime(
            calendar.GetYear(dateTime),
            calendar.GetMonth(dateTime),
            calendar.GetDayOfMonth(dateTime),
            dateTime.Hour,
            dateTime.Minute,
            dateTime.Second,
            dateTime.Millisecond
        );
    }
}