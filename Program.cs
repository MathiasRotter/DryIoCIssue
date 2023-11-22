
using DryIoc.Microsoft.DependencyInjection;

namespace WebApplication1
{
    public class Program
    {
        public static void Main( string[] args )
        {
            var container = new DryIoc.Container();

            var builder = WebApplication.CreateBuilder( args );
            builder.Host.UseServiceProviderFactory( new DryIocServiceProviderFactory( container ) );

            //builder.Services.AddControllers();

            //builder.Services.AddEndpointsApiExplorer();

            builder.Services
                .AddMvc(options => options.EnableEndpointRouting = false)
                .AddControllersAsServices();

            builder.Logging.ClearProviders();
            builder.Logging.AddConsole();

            var app = builder.Build();


            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
