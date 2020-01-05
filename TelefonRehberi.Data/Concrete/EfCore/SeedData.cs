using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TelefonRehberi.Entity;

namespace TelefonRehberi.Data.Concrete.EfCore
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app) 
        {
            TelefonRehberiContext context = app.ApplicationServices.GetRequiredService<TelefonRehberiContext>();


            context.Database.Migrate();


            if (!context.Departmanlar.Any())
            {
                context.Departmanlar.AddRange(
                    new Departman() { DepartmanAdi="IT" }
                   
                    );
                context.SaveChanges();
            }

            if (!context.Calisanlar.Any())
            {
                context.Calisanlar.AddRange(
                    new Calisan() { CalisanAdi="Samet" , CalisanSoyadi="Irkoren" , Telefon="05059799591" , YoneticiId = 1 , DepartmanId=1}
                   
                  
                   
                    );
                context.SaveChanges();
            }
        }

    }
}
