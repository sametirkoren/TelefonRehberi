using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TelefonRehberi.Data.Abstract;
using TelefonRehberi.Entity;

namespace TelefonRehberi.Data.Concrete.EfCore
{
    public class EfAdminRepository : IAdminRepository
    {
        private readonly TelefonRehberiContext context;

        public EfAdminRepository(TelefonRehberiContext _context)
        {
            context = _context;

        }

        public IQueryable<Admin> GetAll()
        {
            return context.Admin;
        }

        public Admin GetById(int adminId)
        {
            return context.Admin.FirstOrDefault(p => p.AdminId== adminId);
        }

        public Admin Kontrol(Admin admin)
        {
            var kontrol = context.Admin.Where(x => x.Eposta == admin.Eposta).SingleOrDefault();
            return kontrol;
        }

        public void UpdateAdmin(Admin entity)
        {
            var admin = GetById(entity.AdminId);

            if(admin != null)
            {
                admin.Eposta = entity.Eposta;
                admin.Sifre = entity.Sifre;
                context.SaveChanges();
            }

            context.SaveChanges();
        }
    }
}
