using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TelefonRehberi.Entity;

namespace TelefonRehberi.Data.Abstract
{
    public interface IAdminRepository
    {
        Admin Kontrol(Admin admin);

        IQueryable<Admin> GetAll();
        Admin GetById(int adminId);

        void UpdateAdmin(Admin entity);
    }
}
