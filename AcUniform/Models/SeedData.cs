using Microsoft.EntityFrameworkCore;
using AcUniform.Data;

namespace AcUniform.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new AcUniformContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<AcUniformContext>>()))
        {
            if (context == null || context.Junior == null)
            {
                throw new ArgumentNullException("Null");
            }

            // Look for any Juniors.
            if (context.Junior.Any())
            {
                return;   // DB has been seeded
            }

            context.Junior.AddRange(
                new Junior
                {
                    Name = "Junior pleated short skirt",
                    Price = 69.00M
                },

                new Junior
                {
                    Name = "Long Skirt",
                    Price = 80.00M
                },

                new Junior
                {
                    Name = "Grey Shorts",
                    Price = 50.00M
                },

                new Junior
                {
                    Name = "Pinstripe shorts",
                    Price = 59.00M
                },

                new Junior
                {
                    Name = "Grey trousers",
                    Price = 66.00M
                },

                new Junior
                {
                    Name = "Polo shirt - short sleeve",
                    Price = 35.00M
                },

                new Junior
                {
                    Name = "Polo shirt - long sleeve",
                    Price = 40.00M
                },

                new Junior
                {
                    Name = "Black/White jersey",
                    Price = 99.00M
                },

                new Junior
                {
                    Name = "PE top",
                    Price = 60.00M
                },

                new Junior
                {
                    Name = "PE shorts",
                    Price = 45.00M
                },

                new Junior
                {
                    Name = "50 denier pantihose",
                    Price = 80.00M
                },

                new Junior
                {
                    Name = "Black ankle socks",
                    Price = 8.50M
                }

             );
            context.SaveChanges();
        }
    }


}    