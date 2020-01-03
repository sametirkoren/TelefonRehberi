using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TelefonRehberi.Entity;

namespace TelefonRehberi.Data.Concrete.EfCore
{
    public class TelefonRehberiContext : DbContext
    {

        public TelefonRehberiContext(DbContextOptions<TelefonRehberiContext> options)
            :base(options)
        {

        }

        public DbSet<Calisan> Calisanlar { get; set; }
        public DbSet<Departman> Departmanlar { get; set; }
    }
}
