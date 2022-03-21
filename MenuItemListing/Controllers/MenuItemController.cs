using MenuItemListing.model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuItemListing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
       [HttpGet]
       public List<MenuItem> Get()
        {
            List<MenuItem> menuItems = new List<MenuItem>();
            new MenuItem() { Id = 1, Name = "Pizza", Active = true, DateOFLaunch = new DateTime(2019, 01, 02), FreeDelivery = false, Price = 300 };
            new MenuItem()
            {
                Id = 2,
                Name = "Burger",
                Active = true,
                DateOFLaunch = new DateTime(2018, 03, 12),
                FreeDelivery = false,
                Price = 500
            };
            new MenuItem()
            {
                Id = 3,
                Name = "Biryani",
                Active = true,
                DateOFLaunch = new DateTime(2014, 12, 11),
                FreeDelivery = true
                ,
                Price = 300
            };
            return menuItems;

            }

        [HttpGet("{id}")]
        public MenuItem GetMenuItemById(int id)
        {
            List<MenuItem> menuItems = new List<MenuItem>();
            new MenuItem() { Id = 1, Name = "Pizza", Active = true, DateOFLaunch = new DateTime(2019, 01, 02), FreeDelivery = false, Price = 300 };
            new MenuItem()
            {
                Id = 2,
                Name = "Burger",
                Active = true,
                DateOFLaunch = new DateTime(2018, 03, 12),
                FreeDelivery = false,
                Price = 500
            };
            new MenuItem()
            {
                Id = 3,
                Name = "Biryani",
                Active = true,
                DateOFLaunch = new DateTime(2014, 12, 11),
                FreeDelivery = true
                ,
                Price = 300
            };
            MenuItem obj = menuItems.SingleOrDefault(i => i.Id == id);
            return obj;

        }

        }
    }

