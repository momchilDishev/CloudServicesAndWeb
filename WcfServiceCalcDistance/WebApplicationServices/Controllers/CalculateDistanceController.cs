using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApplicationServices.Models;

namespace WebApplicationServices.Controllers
{
    [RoutePrefix("api")]
    public class CalculateDistanceController: ApiController
    {
        // GET api/CalculateDistanceBetweenPoints
        [Route("/CalculateDistanceBetweenPoints")]
        [HttpGet]
        public double GetCalculatedDistanceBetweenPoints(Point startpoint, Point endpoint)
        {
            int deltaX = startpoint.X - endpoint.X;
            int deltaY = startpoint.Y - startpoint.Y;

            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }
}