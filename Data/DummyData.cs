using EdmanOnlineShop.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;

namespace EdmanOnlineShop.Data
{
    public class DummyData

    {

        public static byte[] defaultImage;
        public static byte[] sampleImage1;
        public static byte[] sampleImage2;

        public static async Task Initialize(ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager, IHostingEnvironment hostingEnvironment)
        {
            context.Database.EnsureCreated();
            defaultImage =
                System.IO.File.ReadAllBytes(hostingEnvironment.ContentRootPath + "/wwwroot/images/default.jpg");
            sampleImage1 =
                System.IO.File.ReadAllBytes(hostingEnvironment.ContentRootPath + "/wwwroot/images/sample.png");
            sampleImage2 =
                System.IO.File.ReadAllBytes(hostingEnvironment.ContentRootPath + "/wwwroot/images/sample2.png");

            string Admin = "Admin";
            string AdminDescription = "Has access to all modules";

            string Customer = "Customer";
            string CustomerDescription = "Has access to public modules";

            string LogisticsClerk = "LogisticsClerk";
            string LogisticsClerkDescription = "Has access to user, order, delivery, and inventory module";

            string OperationsManager = "OperationsManager";
            string OperationsManagerDescription = "Has access to user, review, order, and delivery module";

            string Accounting = "Accounting";
            string AccountingDescription = "Has access to user and reports module";

            string SalesClerk = "SalesClerk";
            string SalesClerkDescription = "Has access to return, product, review and user module";

            string InternationalCorrespondenceAndSecretary = "InternationalCorrespondenceAndSecretary";
            string InternationalCorrespondenceAndSecretaryDescription =
                "Has access to inventory, request, and user module";


            string DefaultPassword = "P@$$w0rd";

            if (await roleManager.FindByIdAsync(Admin) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(Admin, AdminDescription, DateTime.Now));
            }

            if (await roleManager.FindByIdAsync(Customer) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(Customer, CustomerDescription, DateTime.Now));
            }

            if (await roleManager.FindByIdAsync(LogisticsClerk) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(LogisticsClerk, LogisticsClerkDescription,
                    DateTime.Now));
            }

            if (await roleManager.FindByIdAsync(OperationsManager) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(OperationsManager, OperationsManagerDescription,
                    DateTime.Now));
            }

            if (await roleManager.FindByIdAsync(Accounting) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(Accounting, AccountingDescription, DateTime.Now));
            }

            if (await roleManager.FindByIdAsync(SalesClerk) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(SalesClerk, SalesClerkDescription, DateTime.Now));
            }

            if (await roleManager.FindByIdAsync(InternationalCorrespondenceAndSecretary) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(InternationalCorrespondenceAndSecretary,
                    InternationalCorrespondenceAndSecretaryDescription, DateTime.Now));
            }

            if (await userManager.FindByNameAsync("administrator@edman.com") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "admin",
                    Address = "Manila",
                    Email = "administrator@edman.com",
                    FirstName = "Administrator",
                    LastName = "Admin",
                    Mobile = "912312344",
                    Phone = "023123155"
                };

                var result = await userManager.CreateAsync(user);

                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, DefaultPassword);
                    await userManager.AddToRoleAsync(user, Admin);
                }

            }

            if (await userManager.FindByNameAsync("jdcruz@gmail.com") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "jdcruz",
                    Address = "Manila",
                    Email = "jdcruz@gmail.com",
                    FirstName = "Juan",
                    LastName = "Dela Cruz",
                    Mobile = "912312344",
                    Phone = "023123155"
                };

                var result = await userManager.CreateAsync(user);

                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, DefaultPassword);
                    await userManager.AddToRoleAsync(user, Customer);
                }

            }


            if (await userManager.FindByNameAsync("logistics@edman.com") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "logistics",
                    Address = "Manila",
                    Email = "logistics@edman.com",
                    FirstName = "Logistics",
                    LastName = "Clerk",
                    Mobile = "912312344",
                    Phone = "023123155"
                };

                var result = await userManager.CreateAsync(user);

                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, DefaultPassword);
                    await userManager.AddToRoleAsync(user, LogisticsClerk);
                }

            }


            if (await userManager.FindByNameAsync("operations@edman.com") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "operations",
                    Address = "Manila",
                    Email = "operations@edman.com",
                    FirstName = "Operations",
                    LastName = "Manager",
                    Mobile = "912312344",
                    Phone = "023123155"
                };

                var result = await userManager.CreateAsync(user);

                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, DefaultPassword);
                    await userManager.AddToRoleAsync(user, OperationsManager);
                }
            }


            if (await userManager.FindByNameAsync("accounting@edman.com") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "accounting",
                    Address = "Manila",
                    Email = "accounting@edman.com",
                    FirstName = "Accounting",
                    LastName = "User",
                    Mobile = "912312344",
                    Phone = "023123155"
                };

                var result = await userManager.CreateAsync(user);

                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, DefaultPassword);
                    await userManager.AddToRoleAsync(user, Accounting);
                }
            }


            if (await userManager.FindByNameAsync("sales@edman.com") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "sales",
                    Address = "Manila",
                    Email = "sales@edman.com",
                    FirstName = "Sales",
                    LastName = "User",
                    Mobile = "912312344",
                    Phone = "023123155"
                };

                var result = await userManager.CreateAsync(user);

                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, DefaultPassword);
                    await userManager.AddToRoleAsync(user, SalesClerk);
                }
            }


            if (await userManager.FindByNameAsync("international@edman.com") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "sales",
                    Address = "Manila",
                    Email = "international@edman.com",
                    FirstName = "International",
                    LastName = "User",
                    Mobile = "912312344",
                    Phone = "023123155"
                };

                var result = await userManager.CreateAsync(user);

                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, DefaultPassword);
                    await userManager.AddToRoleAsync(user, InternationalCorrespondenceAndSecretary);
                }
            }

            // Check if there is any products in the db if there is just return no need to seed the DB.
            if (context.Products.Any())
            {
                return;
            }

            var orders = new Order[]
            {
                new Order
                {
                    DateOrdered = DateTime.Now,
                    PaymentMethod = PaymentMethod.CREDIT_CARD,
                    UserID = 1,
                    Status = Status.PLACED,
                    Amount = (decimal) 231.32,
                    Quantity = 32,
                    ProductID = 1
                }
            };

            foreach (Order od in orders)
            {
                context.Orders.Add(od);
            }

            context.SaveChanges();

            var products = new Product[]
            {
                new Product
                {
                    DateAdded = DateTime.Now,
                    Price = (decimal) 45500.00,
                    ProductDescription =
                        "The Bosch line of cordless tools uses the industry's most advanced Lithium-ion technology for greater battery life and more run time, all in a lighter package. The lightweight design of the PS130 12V Max hammer drill/driver is ideal for easy handling in overhead operations and tight spaces and lets users tackle professional jobs with ease. The Bosch PS41 12V Max impact driver offers the precision of variable speed, a light body and a short head length.",
                    ProductName = "12V Max 2-Tool Combo Kit with 3/8 In. Hammer Drill/Driver and Impact Driver",
                    ProductImage = sampleImage1,
                    CategoryID = 1
                },
                new Product
                {
                    DateAdded = DateTime.Now,
                    Price = (decimal) 52132.00,
                    ProductDescription =
                        "The Bosch GKT13-225 Track Saw with Plunge Action delivers precision and power, ideal for making table-saw quality cuts to wood and wood-based sheet goods such as laminated particle boards and plywood. The track-guidance system provides exact adjustments for precision end-to-end cuts and plunge cuts. The saw and track combination makes it a more easily transportable alternative to a table saw. The precision of the track saw and blade combine with the optional Bosch tracks (sold separately) to deliver a straight fast finish cuts. The saw is engineered to fit precisely to the tracks. The saw includes constant electronics to help maintain speed under load. The saw also features a spindle lock, a swiveling hose port and a lock-off mechanism. It features overload protection. It has a single pivot point for both bevel and non-bevel cuts, from -1° (for slight undercuts) to +47° cuts. It allows for efficient dust extraction when connected to a suitable vacuum cleaner. The GKT13-225L Kit includes a 48-tooth 6-1/2 In. track saw blade, blade-change wrench, and an L-Boxx case. Bosch offers a full range of optional attachments, including four different track lengths, connector for connecting multiple tracks, an angle guide and a rip fence.",
                    ProductName = "6-1/2 In. Track Saw with Plunge Action and L-Boxx Carrying Case",
                    ProductImage = sampleImage2,
                    CategoryID = 1
                }
            };

            foreach (Product pd in products)
            {
                context.Products.Add(pd);
            }

            context.SaveChanges();

            var inventories = new Inventory[]
            {
                new Inventory
                {
                    ProductID = 1,
                    Quantity = 100,
                    CriticalLevel = 10,
                    InventoryDate = DateTime.Now
                },
                new Inventory
                {
                    ProductID = 2,
                    Quantity = 100,
                    CriticalLevel = 10,
                    InventoryDate = DateTime.Now
                }
            };

            foreach (Inventory iv in inventories)
            {
                context.Inventories.Add(iv);
            }

            context.SaveChanges();

            var requests = new Request[]
            {
                new Request
                {
                    ProductID = 1,
                    UserID = 1,
                    RequestDate = DateTime.Now,
                    RequestDetails = "Please providee this",
                    RequestHeader = "Request for something",
                }
            };

            foreach (Request rq in requests)
            {
                context.Requests.Add(rq);
            }

            var categories = new Category[]
            {
                new Category
                {
                    CategoryName = "Category 1"
                },
                new Category
                {
                    CategoryName = "Category 2"
                },
                new Category
                {
                    CategoryName = "Category 3"
                }
            };

            foreach (Category ct in categories)
            {
                context.Categories.Add(ct);
            }
       
            context.SaveChanges();

        }
    }
}
