using BookHub.BussinessLayer.Abstract;
using BookHub.BussinessLayer.Concrete;
using BookHub.DataAccesLayer.Abstract;
using BookHub.DataAccesLayer.Concrete;
using BookHub.DataAccesLayer.EntityFramework;
using BookHub.WebApi.Mapping;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System.Net.Security;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using BookHub.DataAccesLayer.Models;



namespace BookHub.WebApi
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
			services.AddDbContext<BookHubProjectContext>(options =>
		    options.UseSqlServer(Configuration.GetConnectionString("DefaultContext")));
			services.AddControllers();

			services.AddMvc();
            services.AddControllers();
            services.AddHttpClient();
            services.AddSwaggerGen();
            services.AddDbContext<Context>();
            services.AddScoped<IKategoriDal, EfKategoriDal>();
            services.AddScoped<IKategoriService, KategoriManager>();



            services.AddScoped<IHikayeDal, EfHikayeDal>();
            services.AddScoped<IHikayeService, HikayeManager>();
            //DOĞRU

			services.AddScoped<IYazarDal, EfYazarDal>();
			services.AddScoped<IYazarService, YazarManager>();


			services.AddScoped<IKullaniciDal, EfKullaniciDal>();
            services.AddScoped<IKullaniciService, KullaniciManager>();

			services.AddScoped<IBultenDal, EfBultenDal>();
			services.AddScoped<IBultenService, BultenManager>();



			services.AddScoped<IBolumDal, EfBolumDal>();
            services.AddScoped<IBolumService, BolumManager>();

            services.AddScoped<IOkuyucuDal, EfOkuyucuDal>();
            services.AddScoped<IOkuyucuService, OkuyucuManager>();

            services.AddScoped<IBegeniDal, EfBegeniDal>();
            services.AddScoped<IBegeniService, BegeniManager>();

            services.AddScoped<IYorumDal, EfYorumDal>();
            services.AddScoped<IYorumService, YorumManager>();


            services.AddAutoMapper(typeof(AutoMapperConfig));
            services.AddControllers();

            services.AddCors(opt =>
            {
            opt.AddPolicy("BookHubApiCors", opts =>
            {
                opts.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
            });
            });

            services.AddControllers().AddNewtonsoftJson(options =>
           options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "HotelProject.WebApi", Version = "v1" });
            });

        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BookHubProject.WebApi v1"));
            }
            app.UseRouting();
            app.UseStaticFiles();
            app.UseCors("BookHubApiCors");
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}

