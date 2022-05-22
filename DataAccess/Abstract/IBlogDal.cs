﻿using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBlogDal: IBaseDal<Blog>
    {
        List<Blog> GetAllWithCategory();
        List<Blog> GetListWithCategoryByWriter(int id);
    }
}
