﻿using CSharpEgitimKampi301.DataaccessLayer.Abstract;
using CSharpEgitimKampi301.DataaccessLayer.Repositories;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataaccessLayer.EntityFramework
{
    public class EfAdminDal : GenericRepository<Admin>, IAdminDal
    {        
    }
}
/*
 Ekle, Sil, Güncelle, Listele ve Id'ye Göre Getir
//İçinde a harfi geçmeyen kullanıcıları Listele
 */