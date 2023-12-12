namespace Aula07._1_WebApp {
    public class Program {
        public static void Main(string[] args) {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            var app = builder.Build();

            // Middleware
            // Usar HTTPs
            app.UseHttpsRedirection();
            // Usar arquivos estáticos
            app.UseStaticFiles();
            // Usar roteamento
            // Https://localhost:7002/minhaapp/index
            app.UseRouting();
            // Usar autenticação
            //app.UseAuthorization();
            // Usar Razor
            app.MapRazorPages();
            // Executar a aplicação
            app.Run();
        }
    }
}