using LINQ.ApplicationLayer.Services.CategoryService;
using LINQ.ApplicationLayer.Services.CustomerService;
using LINQ.ApplicationLayer.Services.EmployeeService;
using LINQ.ApplicationLayer.Services.EmployeeTerritoryService;
using LINQ.ApplicationLayer.Services.OrderDetailService;
using LINQ.ApplicationLayer.Services.OrderService;
using LINQ.ApplicationLayer.Services.ProductService;
using LINQ.ApplicationLayer.Services.RegionService;
using LINQ.ApplicationLayer.Services.ShipperService;
using LINQ.ApplicationLayer.Services.SupplierService;
using LINQ.ApplicationLayer.Services.TerritoryServices;
using LINQ.DomainLayer.Interfaces;
using LINQ.InfrastructureLayer.Repositories;

namespace LINQ.WebAPI.ServiceCollection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            // Domain Interfaces
            services.AddScoped<ICategory, CategoryRepository>();
            services.AddScoped<ICustomer, CustomerRepository>();
            services.AddScoped<IEmployee, EmployeeRepository>();
            services.AddScoped<IEmployeeTerritory, EmployeeTerritoryRepository>();
            services.AddScoped<IOrderDetail, OrderDetailRepository>();
            services.AddScoped<IOrder, OrderRepository>();
            services.AddScoped<IProduct, ProductRepository>();
            services.AddScoped<IRegion, RegionRepository>();
            services.AddScoped<IShipper, ShipperRepository>();
            services.AddScoped<ISupplier, SupplierRepository>();
            services.AddScoped<ITerritory, TerritoryRepository>();
            // Application Service
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IEmployeeTerritoryService, EmployeeTerritoryService>();
            services.AddScoped<IOrderDetailService, OrderDetailService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IRegionService, RegionService>();
            services.AddScoped<IShipperService, ShipperService>();
            services.AddScoped<ISupplierService, SupplierService>();
            services.AddScoped<ITerritoryServices, TerritoryServices>();

            return services;
        }
    }
}