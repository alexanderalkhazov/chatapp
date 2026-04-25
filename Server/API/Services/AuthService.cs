using DAL;

namespace API.Services;

public interface IAuthService
{
    Task<bool> RegisterUser(object request);
}

public class AuthService : IAuthService
{
    private readonly IUnitOfWork _unitOfWork;
    public AuthService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    public async Task<bool> RegisterUser(object request)
    {
        // Implement user registration logic here
        // This might include hashing the password and saving the user to the database
        return true;
    }
}