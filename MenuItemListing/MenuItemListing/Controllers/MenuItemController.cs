using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using MenuItemListing.Models;
using System.Linq;
using System.Threading.Tasks;


namespace MenuItemListing.Controllers
{
    [Route("api/menu")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        public List<MenuItem> menu = new List<MenuItem>()
        {
            new MenuItem(){Id=1,Name="Watch",freeDelivery=true,Price=1000.0,dateOfLaunch=new DateTime(2020,12,12)},
            new MenuItem(){Id=2,Name="Box",freeDelivery=false,Price=500.0,dateOfLaunch=new DateTime(2020,11,12)},
            new MenuItem(){Id=3,Name="Pen",freeDelivery=true,Price=1000.0,dateOfLaunch=new DateTime(2020,10,12)}
        };
        [HttpGet]
        [Route("Get")]
        public IEnumerable<MenuItem> Get()

        {
            return menu;
        }
    }
}
