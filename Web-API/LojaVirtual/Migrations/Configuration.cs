namespace LojaVirtual.Migrations
{
    using LojaVirtual.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LojaVirtual.Models.LojaVirtualContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LojaVirtual.Models.LojaVirtualContext context)
        {
            {
                context.Products.AddOrUpdate(
                p => p.Id,
                new Product{Id = 1,nome = "produto 1",codigo = "COD1", descricao = "descrição produto 1", preco = 100, Url ="www.siecolasystems.com/produto1"},
                new Product{Id = 2,nome = "produto 2",codigo = "COD2", descricao = "descrição produto 2", preco = 200, Url ="www.siecolasystems.com/produto2"},
                new Product{Id = 3,nome = "produto 3",codigo = "COD3", descricao = "descrição produto 3", preco = 300, Url ="www.siecolasystems.com/produto3"}
                );
            }
        }
    }
}
