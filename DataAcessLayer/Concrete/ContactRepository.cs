﻿using DataAcessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.Concrete
{
    public class ContactRepository:RepositoryBase<Contact>,IContactDAL
    {
    }
}
