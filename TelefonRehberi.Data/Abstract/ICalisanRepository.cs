using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TelefonRehberi.Entity;

namespace TelefonRehberi.Data.Abstract
{
    public interface ICalisanRepository
    {
        Calisan GetById(int calisanId);
        IQueryable<Calisan> GetAll();
        void AddCalisan(Calisan entity);
        void UpdateCalisan(Calisan entity);
        void DeleteCalisan(int calisanId);
    }
}
