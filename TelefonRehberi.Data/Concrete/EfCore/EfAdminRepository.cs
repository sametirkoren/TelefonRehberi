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

        public Admin Kontrol(Admin admin)
        {
            var kontrol = context.Admin.Where(x => x.Eposta == admin.Eposta).SingleOrDefault();
            return kontrol;
        }
    }
}
