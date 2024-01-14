﻿using System;
using EntityLayer.Entities;

namespace DataAccessLayer.Abstract
{
	public interface IProductDal : IGenericDal<Product>
	{
		List<Product> GetProductsWithCategories();
	}
}

