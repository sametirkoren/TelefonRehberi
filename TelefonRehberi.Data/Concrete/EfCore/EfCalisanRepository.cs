﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TelefonRehberi.Data.Abstract;
using TelefonRehberi.Entity;

namespace TelefonRehberi.Data.Concrete.EfCore
{
    public class EfCalisanRepository : ICalisanRepository
    {
        private readonly TelefonRehberiContext context;
        public EfCalisanRepository(TelefonRehberiContext _context)
        {
            context = _context;
        }
        public void AddCalisan(Calisan entity)
        {
            context.Calisanlar.Add(entity);
            context.SaveChanges();
        }

        public void DeleteCalisan(int calisanId)
        {
            var calisan = context.Calisanlar.FirstOrDefault(p => p.CalisanId == calisanId);
            if(calisan != null)
            {
                context.Calisanlar.Remove(calisan);
                context.SaveChanges();
            }
        }

        public IQueryable<Calisan> GetAll()
        {
            return context.Calisanlar;
        }

        public Calisan GetById(int calisanId)
        {
            return context.Calisanlar.FirstOrDefault(p => p.CalisanId == calisanId);
        }

        public void UpdateCalisan(Calisan entity)
        {
            context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();

        }
    }
}
