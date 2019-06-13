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
        public static byte[] sampleImage3;
        public static byte[] sampleImage4;
        public static byte[] sampleImage5;
        public static byte[] sampleImage6;
        
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
            sampleImage3 =
                System.IO.File.ReadAllBytes(hostingEnvironment.ContentRootPath + "/wwwroot/images/sample3.png");
            sampleImage4 =
                System.IO.File.ReadAllBytes(hostingEnvironment.ContentRootPath + "/wwwroot/images/sample4.png");
            sampleImage5 =
                System.IO.File.ReadAllBytes(hostingEnvironment.ContentRootPath + "/wwwroot/images/sample5.png");
            sampleImage6 =
                System.IO.File.ReadAllBytes(hostingEnvironment.ContentRootPath + "/wwwroot/images/sample6.png");
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
                    Phone = "023123155",
                    DateRegistered = DateTime.Now
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
                    Phone = "023123155",
                    DateRegistered = DateTime.Now

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
                    Phone = "023123155",
                    DateRegistered = DateTime.Now

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
                    Phone = "023123155",
                    DateRegistered = DateTime.Now

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
                    Phone = "023123155",
                    DateRegistered = DateTime.Now
                    
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
                    Phone = "023123155",
                    DateRegistered = DateTime.Now

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
                    Phone = "023123155",
                    DateRegistered = DateTime.Now

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
                },
                new Product
                {
                    DateAdded = DateTime.Now,
                    Price = (decimal) 143599.00,
                    ProductDescription = "The CM8S 8-1/2 In. single bevel sliding compound miter saw features a Bosch exclusive design delivering a well-balanced saw with a top carry handle at the center of gravity and weighs only 37 pounds. These features easily provide one-handed portability on and off the job. Accessible controls make it easy to change bevel settings without reaching behind the saw. The integrated expanding work piece supports, large easy to read miter and bevel scales, and detent system provides quick and accurate cuts. The CM8S also has the same crosscut capacity (12-1/4 In.) as a 10 In. miter saw, at 30% lighter weight.",
                    ProductName = "8-1/2 In. Single-Bevel Slide Miter Saw",
                    ProductImage = sampleImage3,
                    CategoryID = 2
                },
                new Product
                {
                    DateAdded = DateTime.Now,
                    Price = (decimal) 253599.00,
                    ProductDescription = "The Bosch 4100-10 10 In. Worksite Table Saw with Gravity-Rise Wheeled Stand delivers both professional rip capacity and outstanding portability for a tool that can get the job done, wherever it is. The powerful 15 Amp saw delivers 4.0 max HP for outstanding productivity. It also incorporates soft-start circuitry for smooth but quick ramp-up to the operating speed to manage the intensity of motor start-up and minimize the possibility of tripping a circuit breaker.. It includes Constant Response circuitry to help maintain speed under load, and overload protection. The SquareLock rip fence is engineered for maximum trueness and great ease-of-use, with the fence able to easily glide along the rail for one-handed operation. The lighter GTA47W Gravity-Rise Wheeled Stand has 8 In. treaded rubber-composite tires and a single-action design for easy set-up and transport. It is jobsite-ready with heavy-duty construction. The Smart Guard System is the first modular table saw blade guard, featuring a three-position adjustable riving knife, anti-kickback pawls and non-obstructed-view barrier guard assembly. The table saw provides a 29 In. x 21-1/2 In. square tabletop with a 25 In. rip capacity for ripping 4 Ft. wide sheets goods in half.",
                    ProductName = "10 In. Worksite Table Saw with Gravity-Rise Wheeled Stand",
                    ProductImage = sampleImage4,
                    CategoryID = 2   
                },
                new Product
                {
                    DateAdded = DateTime.Now,
                    Price = (decimal) 199513.50,
                    ProductDescription = "The Bosch DDH183 18V EC Brushless Brute Tough 1/2 In. Drill/Driver Kit features a drill with power and advanced electronics. It offers KickBack Control, which reduces the risk from sudden rotational torque reaction in a bind-up scenario. The tool has an efficient EC Brushless motor for runtime and longer motor life, as well as producing a max of 663 In-Lbs. of torque. The drill has a precision clutch with 25+1 settings, for reduced overtightening, fewer damaged screw heads and a longer tool life. It also has variable-speed selector – one optimized for high-torque driving (0-480 rpm) and one best for high-speed drilling (0-2,100 rpm). With an upgraded, durable all-metal chuck, the drill has great bit grip and torque transfer. It features Bosch's Electronic Motor and Cell Protection, tough Durashield housing, an LED for illumination and a long belt clip. It is an easy tool to handle, with a sure-grip side-assist handle and an ergonomic grip zone.",
                    ProductName = "18V EC Brushless Brute Tough 1/2 In. Drill/Driver",
                    ProductImage = sampleImage5,
                    CategoryID = 3
                },
                new Product
                {
                    DateAdded = DateTime.Now,
                    Price = (decimal) 413510.25,
                    ProductDescription = "The Bosch DDS183 18V EC Brushless Compact Tough 1/2 In. Drill/Driver is a powerful tool that features KickBack Control, which reduces the risk of sudden tool reactions in binding conditions. This integrated acceleration sensor automatically shuts the tool down when a potentially dangerous rotational torque reaction occurs in a bind-up scenario. This cordless drill was fitted with an upgraded, heavy-duty all-metal chuck, for better bit grip and torque transfer. With an efficient EC Brushless motor, this drill/driver provides longer tool life as well as great runtime. It delivers a powerful performance, with 531 In.-Lbs. of torque, two drilling speeds (0-1,900 rpm for high speed and 0-600 rpm for torque) and 20+1 clutch settings. It features the Compact Tough design, with a short head-length and a light weight to make handling easier, but also with professional power. This tool provides an ergonomic grip zone and Bosch's Electronic Motor Protection and Electronic Cell Protection, to help protect the tool and batteries from overload and overheating. It includes a long belt clip for a secure hold.",
                    ProductName = "18V EC Brushless Compact Tough 1/2 In. Drill/Driver",
                    ProductImage = sampleImage6,
                    CategoryID = 3
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
                },
                new Inventory
                {
                    ProductID = 3,
                    Quantity = 100,
                    CriticalLevel = 10,
                    InventoryDate = DateTime.Now
                },
                new Inventory
                {
                    ProductID = 4,
                    Quantity = 100,
                    CriticalLevel = 10,
                    InventoryDate = DateTime.Now
                },
                new Inventory
                {
                    ProductID = 5,
                    Quantity = 100,
                    CriticalLevel = 10,
                    InventoryDate = DateTime.Now
                },
                new Inventory
                {
                    ProductID = 6,
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
                    CategoryName = "Power Tools"
                },
                new Category
                {
                    CategoryName = "Benchtop Tools"
                },
                new Category
                {
                    CategoryName = "Drills, Hammer Drills & Impact Drivers"
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
