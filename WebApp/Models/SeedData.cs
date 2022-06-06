using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApp.Data;
using WebApp.Entities;

namespace WebApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = new WebAppContext(serviceProvider.GetRequiredService<DbContextOptions<WebAppContext>>());
            if (context.Product.Any())
            {
                //context.Database.ExecuteSqlRaw("DELETE FROM PRODUCT");
                //context.SaveChanges();
                return;
            }

            context.Product.AddRange(
                new Product
                {

                    Name = "Pepsi",
                    Price = 5,
                    Class = "Suc"
                },

                new Product
                {

                    Name = "Cola",
                    Price = 4,
                    Class = "Suc"
                },

                new Product
                {

                    Name = "Fanta",
                    Price = 6,
                    Class = "Suc"
                },

                new Product
                {

                    Name = "Orbit",
                    Price = 5.4,
                    Class = "Guma"
                },
                new Product
                {

                    Name = "Tic-Tac",
                    Price = 6.5,
                    Class = "Drajeuri"
                },
                new Product
                {
                    Name = "Telemea",
                    Price = 7,
                    Class = "Branza"
                },
                new Product
                {
                    Name = "Ton",
                    Price = 10,
                    Class = "Peste"
                },
                new Product
                {
                    Name = "Mar",
                    Price = 1,
                    Class = "Fruct"
                },
                new Product
                {
                    Name = "Mango",
                    Price = 2,
                    Class = "Fruct"
                },
                new Product
                {
                    Name = "Rosie",
                    Price = 0.8,
                    Class = "Fruct"
                }
            );
            context.SaveChanges();
            IEnumerable<Product> query = context.Product.Where(product => product.Class == "Suc");
            foreach (var obj in query)
            {
                obj.Price += 0.25 * obj.Price;
            }
            //var query2 =
            //from p in context.Product
            //group p by p.Class into newGroup
            //orderby newGroup.Key
            //select newGroup;
            //var l = new List<string> {"Fruct", "Drajeuri" };
            //foreach (var item in query2)
            //{
            //    if (l.Contains(item.Key))
            //    {
            //        foreach (Product p in item)
            //        {
            //            p.Price = 1;
            //        }
            //    }
            //}
            context.SaveChanges();
        }
    }
}

