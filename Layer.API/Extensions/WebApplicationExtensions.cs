namespace Layer.API.Extensions;

public static class WebApplicationExtensions
{
    public static void InitializeDataBase(this WebApplication app)
    {
        using (var scope = app.Services.CreateScope())
        {
            var services = scope.ServiceProvider;
            try
            {
                //TODO: Подставить свой контекст
                
                // var context = services.GetRequiredService<TicTacToeContext>();
                // DatabaseInitializer.MigrateAndInitialize(context);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while initializing the database: {ex.Message}");
            }
        }
    }
}