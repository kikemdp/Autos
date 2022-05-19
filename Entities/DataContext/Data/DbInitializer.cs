using Entities.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Entities.DataContext.Data
{
    public static class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var _context = new WebApiDbContext(serviceProvider.GetRequiredService<DbContextOptions<WebApiDbContext>>()))
            {

                // Agregando Autos a la BD
                if (_context.Autos.Any())
                {
                    return;
                }

                _context.Autos.AddRange(
                    new Auto
                    {
                        Modelo = "Volkswagen Amarok",
                        TenantId = 1,
                        Precio = 200000,
                        Anio = 2020
                    },

                    new Auto
                    {
                        Modelo = "Fiat Siena",
                        TenantId = 2,
                        Precio = 150000,
                        Anio = 2004
                    },

                    new Auto
                    {
                        Modelo = "Renault Koleos",
                        TenantId = 2,
                        Precio = 3000000,
                        Anio = 2017
                    }
                );

                _context.SaveChanges();
            }
        }
    }
}
