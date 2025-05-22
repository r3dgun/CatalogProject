using LiteDB;
using System.Collections.Generic;
using System;
using System.Drawing;
using Models;

namespace Models
{

    public class Company
    {
        [BsonId]
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string Logo { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
    public class DgvCompany
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public Image Logo { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public DateTime CreatedAt { get; set; }  
        public string CategoryIds { get; set; }
    }
    public class Category
    {
        [BsonId]
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
    public class DgvCategory
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Image Image { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ProductIds { get; set; } 
    }
    public class Product
    {
        [BsonId]
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public string Name { get; set; }
        public string MainText { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public string Image { get; set; }
        public string SecondImage { get; set; }
        public string ThirdImage { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }

    public class DgvProduct
    {
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public string Name { get; set; }
        public string MainText { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public Image Image { get; set; }
        public Image SecondImage { get; set; }
        public DateTime CreatedAt { get; set; } 
        public string OptionIds { get; set; } 
    }
    public class Option
    {
        [BsonId]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class DgvOption
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
    public class ResultDto<T>: ResultDto
    {
        public T Data { get; set; }
    }
    public class ResultDto
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
    }
    public class ThemeColors
    {
        public string GradientTopLeft { get; set; }
        public string GradientTopRight { get; set; }
        public string GradientBottomLeft { get; set; }
        public string GradientBottomRight { get; set; }

        // رنگ دکمه در سه حالت
        public string ButtonIdleColor { get; set; }
        public string ButtonHoverColor { get; set; }
        public string ButtonPressedColor { get; set; }

        public string CardBGColor { get; set; }
        public string BGColor { get; set; }
        public string BGImageName { get; set; }

    }
    public class ThemeFont
    {
        public string FontFamily { get; set; }
        public float Size { get; set; }
        public FontStyle Style { get; set; }

        public Font ToFont()
        {
            return new Font(FontFamily, Size, Style);
        }
    }
}


