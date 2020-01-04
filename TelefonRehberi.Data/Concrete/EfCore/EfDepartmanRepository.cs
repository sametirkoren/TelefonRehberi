using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TelefonRehberi.Data.Abstract;
using TelefonRehberi.Entity;

namespace TelefonRehberi.Data.Concrete.EfCore
{
    public class EfDepartmanRepository : IDepartmanRepository
    {
        private readonly TelefonRehberiContext context;
        public EfDepartmanRepository(TelefonRehberiContext _context)
        {
            context = _context;
        }
        public void AddDepartman(Departman entity)
        {
            context.Departmanlar.Add(entity);
            context.SaveChanges();
        }

        public void DeleteDepartman(int departmanId)
        {
            var departman = context.Departmanlar.FirstOrDefault(p => p.DepartmanId == departmanId);
            if(departman != null)
            {
                context.Departmanlar.Remove(departman);
                context.SaveChanges();
            }
        }

        public IQueryable<Departman> GetAll()
        {
            return context.Departmanlar;
        }

        public Departman GetById(int departmanId)
        {
            return context.Departmanlar.FirstOrDefault(p => p.DepartmanId == departmanId);

        }

        public void UpdateDepartman(Departman entity)
        {
            var departman = GetById(entity.DepartmanId);

            if(departman != null)
            {
                departman.DepartmanAdi = entity.DepartmanAdi;
                context.SaveChanges();
            }
            context.SaveChanges();
        }
    }
}
