﻿using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Account
{
    public interface IAuthenticate
    {
        Task<bool> AuthenticateAsync(string email, string password);
        Task<bool> RegisterUserAsync(string email, string password);
        Task Logout();
    }
}
