using ChozaGamer.DataAccess.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChozaGamer.DataAccess.IRepositories
{
    public interface IUserRepository
    {
        Task<bool> RegisterUserAsync(RegisterUserDTO registerUser);
        Task<bool> LoginUserAsync(LoginUserDTO loginUser);
        Task<UserDTO> GetUserByUsernameAsync(string username);
    }
}
