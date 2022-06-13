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

   [HttpGet("{id}")]
   public ActionResult GetProductById(int id)
   {

       return Ok(new { productId = id , name = "VueJS" });
   }

    [HttpGet("search/{id}/{category}")]
   public ActionResult SearchProductsById(int id,string category)
   {

       return Ok(new { productId = id , name = "VueJS", cat = category});
   }
   
   [HttpGet("query/product")]
   public ActionResult QueryProductsById([FromQuery] int id,[FromQuery] string category)
   {
       return Ok(new { productId = id , name = "VueJS", cat = category});
   }
   
   [HttpGet("query/product/{name}")]
   public ActionResult QueryProductsByIdv2([FromQuery] int id,[FromQuery] string category, string name)
   {
       return Ok(new { productId = id , nameProduct = name, cat = category});
   }
   
   [HttpPost]
   public ActionResult<Product> AddProductv1([FromBody] Product product) // FromBody fix json FormForm fix multipart
   {
       return Ok(product);
   }

      [HttpPost("add")]
   public ActionResult<Product> AddProductv2([FromForm] Product product) // FromBody fix json FormForm fix multipart
   {
       return Ok(product);
   }

   [HttpPut("{id}")]
   public ActionResult UpdateProductId(int id,[FromForm] Product product)
   {
       if(id != product.id){
        return BadRequest();
       }

       if(id != 11111){
         return NotFound();
       }

       return Ok(product);       
   }

[HttpDelete("{id}")]
public ActionResult DeleteById(int id)
{
    if(id!=11111){
        return NotFound();
    }

    return NoContent();
}


   public class Product {
    public int id { get; set; } 
    public string name { get; set; }
    
    public int price { get; set; }
   }
   
}