using CarBook.Application.Features.CQRS.Handlers.AboutHandlers;
using CarBook.Application.Features.CQRS.Handlers.BannerHandlers;
using CarBook.Application.Features.CQRS.Handlers.BrandHandlers;
using CarBook.Application.Features.CQRS.Handlers.CarHandlers;
using CarBook.Application.Features.CQRS.Handlers.CategoryHandlers;
using CarBook.Application.Features.CQRS.Handlers.ContactHandlers;
using CarBook.Application.Repositories;

using CarBook.Domain.Entities;
using CarBook.Persistance;
using CarBook.Persistance.Context;
using CarBook.Persistance.Repositories;

using CarBook.Application.Services;

using Microsoft.AspNetCore.Hosting;
using CarBook.Application.Features.CQRS.Results.CarResult;
using CarBook.Application.Interfaces.BlogRepositories;
using CarBook.Application.Interfaces.CarPricingRepositories;
using CarBook.Application.Interfaces.CarRepositories;
using CarBook.Persistance.Repositories.BlogRepositories;
using CarBook.Persistance.Repositories.CarPricingRepositories;
using CarBook.Persistance.Repositories.CarRepositories;
using CarBook.Application.Features.RepositoryPattern.CommentRepositories;
using CarBook.Persistance.Repositories.CommentRepositories;
using CarBook.Application.Interfaces.TagCloudRepositories;
using CarBook.Persistance.Repositories.TagCloudRepositories;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddScoped<CarBookDbContext>();

        builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        builder.Services.AddScoped<ICarRepository, CarRepository>();
        builder.Services.AddScoped<IBlogRepository, BlogRepository>();
        builder.Services.AddScoped<ICarPricingRepository, CarPricingRepository>();
        builder.Services.AddScoped<ITagCloudRepositorty, TagCloudRepository>();
        builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(CommentRepository<>));



        builder.Services.AddScoped<GetAboutQueryHandler>();
        builder.Services.AddScoped<GetAboutByIdQueryHandler>();
        builder.Services.AddScoped<CreateAboutCommandHandler>();
        builder.Services.AddScoped<UpdateAboutCommandHandler>();
        builder.Services.AddScoped<RemoveAboutCommandHandler>();


        builder.Services.AddScoped<GetBannerQueryHandler>();
        builder.Services.AddScoped<GetBannerByIdQueryHandler>();
        builder.Services.AddScoped<CreateBannerCommandHandler>();
        builder.Services.AddScoped<UpdateBannerCommandHandler>();
        builder.Services.AddScoped<RemoveBannerCommandHandler>();



        builder.Services.AddScoped<GetBrandQueryHandler>();
        builder.Services.AddScoped<GetBrandByIdQueryHandler>();
        builder.Services.AddScoped<CreateBrandCommandHandler>();
        builder.Services.AddScoped<UpdateBrandCommandHandler>();
        builder.Services.AddScoped<RemoveBrandCommandHandler>();


        builder.Services.AddScoped<GetCarQueryHandler>();
        builder.Services.AddScoped<GetCarByIdQueryHandler>();
        builder.Services.AddScoped<CreateCarCommandHandler>();
        builder.Services.AddScoped<UpdateCarCommandHandler>();
        builder.Services.AddScoped<RemoveCarCommandHandler>();
        builder.Services.AddScoped<GetCarWithBrandQueryHandler>();
        builder.Services.AddScoped<GetLas5CarWithBrandQueryHandler>();


        builder.Services.AddScoped<GetCategoryQueryHandler>();
        builder.Services.AddScoped<GetCategoryByIdQueryHandler>();
        builder.Services.AddScoped<CreateCategoryCommandHandler>();
        builder.Services.AddScoped<UpdateCategoryCommandHandler>();
        builder.Services.AddScoped<RemoveCategoryCommandHandler>();

        builder.Services.AddScoped<GetContactQueryHandler>();
        builder.Services.AddScoped<GetContactByIdQueryHandler>();
        builder.Services.AddScoped<CreateContactCommandHandler>();
        builder.Services.AddScoped<UpdateContactCommandHandler>();
        builder.Services.AddScoped<RemoveContactCommandHandler>();



        builder.Services.AddApplicationService(builder.Configuration);

        builder.Services.AddControllers();



        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.UseRouting();

        app.MapControllerRoute(name: "default",
            pattern: "{controller=Home }/{action=Index}/{id?}");

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "adminBanner",
                pattern: "Admin/{controller=AdminBanner}/{action=Index}/{id?}"
            );
        });



        app.Run();
    }
}