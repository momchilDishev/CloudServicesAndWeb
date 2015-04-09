namespace EmptyWebApi2.Controllers
{
    using EmptyWebApi2.Models;
    using System;
    using System.Collections.Generic;
    using System.Web.Http;
    public class StudentsController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetStudents()
        {
            var students = new List<StudentsDataModel>() 
            {
                new StudentsDataModel{Name = "Peter", BirthDate = new DateTime(1999, 10, 10), Username = "peter"},
                new StudentsDataModel{Name = "Misho", BirthDate = new DateTime(1998, 11, 11), Username = "misho"},
                new StudentsDataModel{Name = "Lora", BirthDate = new DateTime(1997, 12, 12), Username = "lora"}
            };

            return this.Ok(students);
        }


    }
}