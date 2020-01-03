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
                    new Departman() { DepartmanAdi="IT" },
                    new Departman() { DepartmanAdi="Matematik" }
                    );
                context.SaveChanges();
            }

            if (!context.Calisanlar.Any())
            {
                context.Calisanlar.AddRange(
                    new Calisan() { CalisanAdi="Samet" , CalisanSoyadi="Irkoren" , Telefon="05059799591" , YoneticiId = 1 , DepartmanId=1},
                    new Calisan() { CalisanAdi="Derya" , CalisanSoyadi="Irkoren" , Telefon="05343004948" , YoneticiId = 1000 , DepartmanId=1},
                    new Calisan() { CalisanAdi="Berkcan" , CalisanSoyadi="Tazeler" , Telefon="05374103498" , YoneticiId = 1000 , DepartmanId=1},
                    new Calisan() { CalisanAdi="Zeynep" , CalisanSoyadi="Kalafat" , Telefon="05388363115" , YoneticiId = 1002  , DepartmanId=2},
                    new Calisan() { CalisanAdi="Rabia" , CalisanSoyadi="Tekin" , Telefon="05353786212" , YoneticiId = 1002 , DepartmanId=2}
                   
                    );
                context.SaveChanges();
            }
        }

    }
}
