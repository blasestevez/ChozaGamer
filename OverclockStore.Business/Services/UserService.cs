using AutoMapper;
using OverclockStore.DataAccess.Models.DTOs;
using OverclockStore.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverclockStore.Business.Services
{
    public class UserService
    {
        private readonly UserRepository repository;

        public UserService(UserRepository repository)
        {
            this.repository = repository;
        }

        public async Task<bool> LoginUserAsync(LoginUserDTO loginUser)
        {
            var response = await repository.LoginUserAsync(loginUser);
            return response;
        }

        public async Task<bool> RegisterUserAsync(RegisterUserDTO registerUser)
        {
            var response = await repository.RegisterUserAsync(registerUser);
            return response;
        }

        public async Task<UserDTO> GetUserByUsernameAsync(string username)
        {
            var response = await repository.GetUserByUsernameAsync(username);
            return response;
        }
    }
}
