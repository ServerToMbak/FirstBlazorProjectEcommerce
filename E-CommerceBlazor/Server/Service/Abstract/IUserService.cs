﻿using E_CommerceBlazor.Server.Model;

namespace E_CommerceBlazor.Server.Service.Abstract
{
    public interface IUserService
    {
        public Task<User> GetByMail(string Email);
        public Task<bool> UserExist(string Email);
    }
}
