

namespace SoftUniWebApiSelfHost
{
    using System;
    using System.Net.Http;
    using System.Web.Http;

    [RoutePrefix("api/products")]
    public class ProductController : ApiController
    {
        [Route("list")]
        [HttpGet]
        public string ListProducts()
        {
            return "products";
        }

        [Route("{id:int}")]
        public string GetProduct(int id)
        {
            return "product" + id;
        }

        [Route("{name}")]
        public IHttpActionResult GetProduct(string name)
        {
            var product = new Product(name);

            return this.Ok(product);
        }
    }
}