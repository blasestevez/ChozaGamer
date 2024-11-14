using AutoMapper;
using ChozaGamer.DataAccess.IRepositories;
using ChozaGamer.DataAccess.Models.Domain;
using ChozaGamer.DataAccess.Models.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChozaGamer.DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;

        public UserRepository(ApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<UserDTO> GetUserByUsernameAsync(string username)
        {
            var user = await dbContext.Users.FirstOrDefaultAsync(x => x.username == username);
            
            if (user == null)
            {
                return null;
            }

            UserDTO userDTO = mapper.Map<UserDTO>(user);
            return userDTO;
        }

        public async Task<bool> LoginUserAsync(LoginUserDTO loginUser)
        {
            var user = await dbContext.Users.FirstOrDefaultAsync(x => x.username == loginUser.username);
            if (user == null)
            {
                return false;
            }

            try
            {
                bool isPasswordValid = PasswordHasher.VerifyPassword(loginUser.password, user.hashedPassword);
                return isPasswordValid;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> RegisterUserAsync(RegisterUserDTO registerUser)
        {
            var user = mapper.Map<User>(registerUser);
            user.hashedPassword = PasswordHasher.HashPassword(registerUser.password);

            await dbContext.Users.AddAsync(user);
            await dbContext.SaveChangesAsync();

            return true;
        }
    }
}
