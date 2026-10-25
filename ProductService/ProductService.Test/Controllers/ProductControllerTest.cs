using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using ProductService.DataAccess.EF;
using ProductService.Api.Queries.Dtos;
using ProductService.Test.TestData;
using Xunit;
using static Xunit.Assert;

namespace ProductService.Test.Controllers;

public class ProductsControllerTest : IClassFixture<ProductServiceTestApplicationFactory>
{
    private readonly ProductServiceTestApplicationFactory factory;

    public ProductsControllerTest(ProductServiceTestApplicationFactory factory)
    {
        this.factory = factory;
    }

    [Fact]
    public async Task GetAll_ReturnsJsonResult_WithListOfProducts()
    {
        var client = factory.CreateClient();

        var response = await client.DoGetAsync<List<ProductDto>>("/api/Products");

        True(response.Count > 1);
    }


    [Fact]
    public async Task GetByCode_ReturnsJsonResult_WithOneProductOfCorrectType()
    {
        var productTravel = TestProductDtoFactory.Travel();

        var client = factory.CreateClient();

        var response = await client.DoGetAsync<ProductDto>("/api/Products/" + productTravel.Code);

        Equal(productTravel.Code, response.Code);
        Equal(productTravel.Name, response.Name);
        Equal(productTravel.Description, response.Description);
    }
}

public class ProductServiceTestApplicationFactory : WebApplicationFactory<Program>
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureTestServices(services =>
        {
            services.RemoveAll<IHostedService>();
            services.RemoveAll<ProductDbContext>();
            services.RemoveAll<DbContextOptions<ProductDbContext>>();
            services.AddDbContext<ProductDbContext>(options =>
                options.UseInMemoryDatabase("ProductsTest"));
        });
    }
}
