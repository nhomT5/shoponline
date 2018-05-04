﻿using ShopOnline.Data.Infrastructure;
using ShopOnline.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Data.Respositories
{
    public interface IProductRepository
    {

    }
    public class ProductRepository:RepositoryBase<Product>,IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
            
        }
    }
}
