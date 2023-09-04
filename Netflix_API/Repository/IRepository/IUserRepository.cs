using Netflix_API.Model.DTO;
using Netflix_API.Model;

namespace Netflix_API.Repository.IRepository
{//user security interface
    public interface IUserRepository
    {
        bool IsUniqueUser(string username);

        Task<LoginResponseDTO> Login(LoginRequestDT0 loginRequestDTO);
        Task<LocalUser> Register(RegisterationRequestDTO registerationRequestDTO);
    }
}
