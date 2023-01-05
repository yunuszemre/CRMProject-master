using CRMProject.BL.Abstract;
using CRMProject.BL.Concrete;
using CRMProject.DAL.Abstract;
using CRMProject.DAL.Concrete.EF.Context;
using CRMProject.DAL.Concrete.EF.Repository;
using Microsoft.EntityFrameworkCore;
using FluentValidation.AspNetCore;
using FluentValidation;
using CRMProject.BL.Validation;
using CRMProject.DTO.Pages;

var builder = WebApplication.CreateBuilder(args);

// EF Context nesnemizi servislere ekledik. DI kısmında artık nesneler içerisine inject edilecek.

builder.Services.AddDbContext<CRMContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DB"));
});

// Add services to the container.
builder.Services.AddControllersWithViews();

// service
builder.Services.AddScoped<IUserAccountService, UserAccountService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IUserAccountService, UserAccountService>();

// repo
builder.Services.AddScoped<IUserAccountRepository, UserAccountRepository>();
builder.Services.AddScoped<IProductRepositoroy, ProductRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ISupplierRepository, SupplierRepository>();



builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddScoped<IValidator<UserAccountDTO>, UserAccountDTOValidation>();





var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");

app.Run();
