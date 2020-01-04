using System;
using System.Collections.Generic;
using System.Text;
using TelefonRehberi.Entity;

namespace TelefonRehberi.Data.Abstract
{
    public interface IAdminRepository
    {
        Admin Kontrol(Admin admin);
    }
}
