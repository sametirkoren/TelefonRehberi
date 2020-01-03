using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TelefonRehberi.Entity;

namespace TelefonRehberi.Data.Abstract
{
    public interface IDepartmanRepository
    {
        Departman GetById(int departmanId);
        IQueryable<Departman> GetAll();

        void AddDepartman(Departman entity);
        void UpdateDepartman(Departman entity);
        void DeleteDepartman(int entity);



    }
}
