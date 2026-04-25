namespace API.Routes;

public static class MainRouter
{
    public static void MapAllRoutes(this WebApplication app)
    {
        app.MapAuthRoutes();
        // app.MapUserRoutes();
        // app.MapConversationRoutes();
    }
}