using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Controllers.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class control : Controller
    {
        public IEnumerable<Product> GetAll()
        {
            
            return new List<Product>{
         new Product{
             Id =1,
             name="sabin",
             Address="123 main st"
         },
    new Product{
             Id =1,
             name="james",
             Address="125 main st"
            },
 
        };
    }
}
}
    
