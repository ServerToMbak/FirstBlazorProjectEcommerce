﻿using E_CommerceBlazor.Server.Model;

namespace E_CommerceBlazor.Server.Service.Abstract
{
    public interface IProductRepository
    {
        Task<Response> Add (Product product);
        Task<Response> Delete(int id);
        Task<DataResponse<Product>> GetById(int id);
        Task<DataResponse<List<Product>>> GetAll();
    }
}
