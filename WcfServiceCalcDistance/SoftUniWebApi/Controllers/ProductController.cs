using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Linq;

namespace SoftUniWebApi.Controllers
{
    using SoftUniWebApiSelfHost.Models;

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
        public HttpResponseMessage GetProductName(string name)
        {
            var response = new HttpResponseMessage();

            if (name.StartsWith("Christmas"))
            {
                response.StatusCode = HttpStatusCode.NotFound;
            }
            else
            {
                response.StatusCode = HttpStatusCode.NoContent;
            }

            return response;

        }
    }
}