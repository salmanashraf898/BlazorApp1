using BlazorApp1.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp1.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<productdetail> Get()
        {
            IList<productdetail> productdetails = new List<productdetail>();
            productdetails.Add(new productdetail { Id = 1, ProductName = "Shirt", Prize = 20, Describtion = "Red Shirt" });
            productdetails.Add(new productdetail { Id = 2, ProductName = "Trouser", Prize = 20, Describtion = "Red Shirt" });
            productdetails.Add(new productdetail { Id = 3, ProductName = "T-shirt", Prize = 20, Describtion = "Red Shirt" });
            return productdetails;
        }
   }
}
