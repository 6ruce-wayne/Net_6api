using Microsoft.AspNetCore.Mvc;

namespace NET_6API.Controllers;

[ApiController]
[Route("[controller]")]
public class DemoController : ControllerBase
{
   [HttpGet]
   public ActionResult<List<string>> GetProducts(){
       var products = new List<string>(); 
       products.Add("VueJS");
       products.Add("Flutter");
       products.Add("React");

       return Ok(products);
   }
}
