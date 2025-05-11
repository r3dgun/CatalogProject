using CatalogProject.Servise.Company;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BunifuGradientPanelDemo;
using CatalogProject.Servise.Product;
using CatalogProject.Servise.Category;
using CatalogProject.Servise;
using CatalogProject.Forms.CategoryForm;
using CatalogProject.Servise.Option;
using CatalogProject.Forms.CompanyForm;
using CatalogProject.ProductFroms;
using CatalogProject.Forms.ShowingForms;

namespace CatalogProject
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            ServiceProvider = services.BuildServiceProvider();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mainForm = ServiceProvider.GetRequiredService<MainForm>();
            Application.Run(mainForm);
        }
        private static void ConfigureServices(IServiceCollection services)
        {

            // ثبت دیتابیس به صورت Scoped یا Singleton
            services.AddSingleton<DatabaseContext>();
            services.AddSingleton<ICompanyService, CompanyService>();
            services.AddSingleton<IProductService, ProductService>();
            services.AddSingleton<IOptionService, OptionService>();
            services.AddSingleton<ICategoryService, CategoryService>();

            // ثبت فرم‌ها
            services.AddTransient<MainForm>();
            services.AddTransient<AddCategoryFrm>(); // فرم‌هایی که وابسته به این سرویس هستن
            services.AddTransient<CategoryListFrm>(); // فرم‌هایی که وابسته به این سرویس هستن
            services.AddTransient<AddCompanyFrm>(); // فرم‌هایی که وابسته به این سرویس هستن
            services.AddTransient<CompanyListFrm>(); // فرم‌هایی که وابسته به این سرویس هستن
            services.AddTransient<AddProductFrom>(); // فرم‌هایی که وابسته به این سرویس هستن
            services.AddTransient<ProductsListFrm>(); // فرم‌هایی که وابسته به این سرویس هستن
            services.AddTransient<CategoriesFrm>(); // فرم‌هایی که وابسته به این سرویس هستن
            services.AddTransient<ProductFrm>(); // فرم‌هایی که وابسته به این سرویس هستن
            services.AddTransient<ProductsFrm>(); // فرم‌هایی که وابسته به این سرویس هستن
            services.AddTransient<CompaniesFrm>(); // فرم‌هایی که وابسته به این سرویس هستن

            
            Program.ServiceProvider = services.BuildServiceProvider();

        }
    }
}
