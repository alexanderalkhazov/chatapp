using API.Services;

namespace API.Routes;

public static class AuthRouter
{
    public static void MapAuthRoutes(this WebApplication app)
    {
        var group = app.MapGroup("/auth");

        group.MapPost("/register", async (object request, IAuthService service) =>
        {
            return Results.Ok("User registered successfully");
        });

        group.MapPost("/login", async (object request) =>
        {
            return Results.Ok("User logged in successfully");
        });
    }
}