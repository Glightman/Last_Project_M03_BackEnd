using CarStore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarStore.Data
{
    public static class SeedDatabase
    {
        public static void Initialize(IHost app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;
                var context = serviceProvider.GetRequiredService<CarStoreContext>();

                context.Database.Migrate();

                if (!context.Carro.Any())
                {
                    context.Carro.Add(new Carro
                    {
                        marca = "Chevrolet",
                        modelo = "Onix",
                        ano = 2018,
                        preco = 52000,
                        url1 = "https://revistacarro.com.br/wp-content/uploads/2018/05/chevrolet_onix_lt_1.4_1.png",
                        descricao = "Carro Semi novo. unico dono"
                    });
                    context.Carro.Add(new Carro
                    {
                        marca = "Chevrolet",
                        modelo = "S10",
                        ano = 2018,
                        preco = 150000,
                        url1 = "https://production.autoforce.com/uploads/version/profile_image/5100/model_main_comprar-4x4-2-8-diesel-lt-pacote-r7n_32f5a22372.png",
                        descricao = "Carro Semi novo. unico dono"
                    });
                    context.Carro.Add(new Carro
                    {
                        marca = "Ford",
                        modelo = "Ká Sedan",
                        ano = 2016,
                        preco = 43000,
                        url1 = "https://gqled.com.br/wp-content/uploads/2019/11/NOVO-KA-1.png",
                        descricao = "Carro Semi novo. unico dono"
                    });
                    context.Carro.Add(new Carro
                    {
                        marca = "Ford",
                        modelo = "Eco Sport",
                        ano = 2020,
                        preco = 87000,
                        url1 = "https://production.autoforce.com/uploads/version/profile_image/3012/comprar-freestyle-1-5-at_839776741a.png",
                        descricao = "Carro Semi novo. unico dono"
                    });
                    context.Carro.Add(new Carro
                    {
                        marca = "Fiat",
                        modelo = "Strada",
                        ano = 2019,
                        preco = 74500,
                        url1 = "https://revistacarro.com.br/wp-content/uploads/2018/05/2.png",
                        descricao = "Carro Semi novo. unico dono"
                    });
                    context.Carro.Add(new Carro
                    {
                        marca = "Fiat",
                        modelo = "Argo",
                        ano = 2021,
                        preco = 68730,
                        url1 = "https://production.autoforce.com/uploads/version/profile_image/5352/comprar-1-0_8a75988860.png",
                        descricao = "Carro NOVO"
                    });
                    context.Carro.Add(new Carro
                    {
                        marca = "VolksWagen",
                        modelo = "Voyage",
                        ano = 2018,
                        preco = 52000,
                        url1 = "https://importadora.ams3.digitaloceanspaces.com/2018/08/VoyageAutomtico.png",
                        descricao = "Carro Semi novo. unico dono"
                    });
                    context.Carro.Add(new Carro
                    {
                        marca = "VolksWagen",
                        modelo = "Amarok",
                        ano = 2021,
                        preco = 210000,
                        url1 = "https://i1.wp.com/2021volkswagen.com/wp-content/uploads/2020/11/unnamed-file-36.png",
                        descricao = "Carro NOVO"
                    });
                    context.Carro.Add(new Carro
                    {
                        marca = "Jeep",
                        modelo = "Renegade",
                        ano = 2018,
                        preco = 91200,
                        url1 = "https://production.autoforce.com/uploads/version/profile_image/1463/comprar-1-8-flex-at-pcd_a4a28811f9.png",
                        descricao = "Carro Semi novo. unico dono"
                    });
                    context.Carro.Add(new Carro
                    {
                        marca = "Toyota",
                        modelo = "Hilux SW4",
                        ano = 2021,
                        preco = 283000,
                        url1 = "https://grandbrasil.com.br/wp-content/uploads/2020/03/7f5d4-https-production.autoforce.com-uploads-version-profile_image-1115-model_main_comprar-flex-2-7_701fbe4b56.png",
                        descricao = "Carro Novo"
                    });
                }

                context.SaveChanges();
            }
        }
    }
}
