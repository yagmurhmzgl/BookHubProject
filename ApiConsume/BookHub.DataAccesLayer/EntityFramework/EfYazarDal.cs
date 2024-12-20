﻿using BookHub.DataAccesLayer.Abstract;
using BookHub.DataAccesLayer.Concrete;
using BookHub.DataAccesLayer.Repositories;
using BookHub.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.DataAccesLayer.EntityFramework
{
	public class EfYazarDal : GenericRepository<Yazar>, IYazarDal
	{
		public EfYazarDal(Context context) : base(context)
		{
		}
	}
}
