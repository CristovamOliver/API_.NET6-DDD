using AutoMapper;
using CrossCutting;

namespace WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            DependencyInjection.DependencyServices(services);

            var config = new AutoMapper.MapperConfiguration(config =>
            {
                config.AddProfile(new MappingEntidade());
            });

            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);

            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();


        }

        public void Configure(WebApplication app, IWebHostEnvironment environment)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();


        }
    }
}