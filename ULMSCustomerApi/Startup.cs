using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ULMSCustomerApi.AutoMapper;
using ULMSDomain.Contracts;
using ULMSDomain.Contracts.Repository;
using ULMSDomain.Contracts.Services;
using ULMSDomain.Services;
using ULMSRepository.Context;
using ULMSRepository.Logic;

namespace ULMSCustomerApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //TODO: Move connection string to config file.
            var connection = "Server=MANE2\\MANELISI;Database=ULMSCustomer;Trusted_Connection=True;";
            services.AddDbContext<ULMSCustomerContext>(options => options.UseSqlServer(connection));
            services.AddMvc();
            
            //Customer
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();

            //Email Address
            services.AddTransient<IEmailAddressService, EmailAddressService>();
            services.AddTransient<IEmailAddressRepository, EmailAddressRepository>();

            //Postal Address
            services.AddTransient<IPostalAddressService, PostalAddressService>();
            services.AddTransient<IPostalAddressRepository, PostalAddressRepository>();

            //Cell phone number
            services.AddTransient<ICellPhoneNumbersService, CellPhoneNumbersService>();
            services.AddTransient<ICellPhoneNumbersRepository, CellPhoneNumbersRepository>();
            
            //Residential address
            services.AddTransient<IResidentialAddressService, ResidentialAddressService>();
            services.AddTransient<IResidentialAddressRepository, ResidentialAddressRepository>();
            
            CustomerMapper.InitializeCustomerMapper();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
