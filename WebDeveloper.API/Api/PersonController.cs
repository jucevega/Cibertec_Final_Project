using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;
using WebDeveloper.Model.DTO;

namespace WebDeveloper.API.Api
{
    [RoutePrefix("person")]
    public class PersonController : ApiController
    {   
        PersonRepository _person;
        public PersonController(PersonRepository person)
        {
            _person = person;
        }

        [HttpGet]
        [Route("list/{page:int?}/rows/{size:int?}")]
        public IHttpActionResult List(int? page, int? size )
        {
            if (!page.HasValue || !size.HasValue)
            {
                page = 1;
                size = 10;
            }
            return Ok(_person.GetListDtoPage(page.Value, size.Value));

        }

        [HttpGet]        
        [Route("edit/{id:int}")]
        public IHttpActionResult EditById(int id)
        {
            var person = _person.GetById(id);
            return Ok(person);
        }

        [HttpPost]
        public IHttpActionResult Person(Person person)
        {            
            return Ok("Post ok");
        }

        [HttpPut]
        public IHttpActionResult TestPut()
        {
            return Ok("Put ok");
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var person = _person.GetById(id);
            if(_person.Delete(person)>0)
                return Ok($"The record {person.BusinessEntityID} was deleted");
            return BadRequest("There is an issue");
        }
    }
}
