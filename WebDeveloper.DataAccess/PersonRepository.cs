using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;
using WebDeveloper.Model.DTO;
using System.Data.Entity;

namespace WebDeveloper.DataAccess
{
    public class PersonRepository : BaseDataAccess<Person>
    {
        public IEnumerable<PersonModelView> GetListDto()
        {
            using (var dbContext = new WebContextDb())
            {
                return Automapper.GetGeneric<IEnumerable<Person>, List<PersonModelView>>(dbContext.CompletePerson().OrderByDescending(x => x.ModifiedDate));
            }
        }

        public IEnumerable<PersonModelView> GetListDtoPage(int page, int size)
        {
            using (var dbContext = new WebContextDb())
            {
                return Automapper.GetGeneric<IEnumerable<Person>, List<PersonModelView>>(dbContext.Persons.Page(page,size).OrderByDescending(x => x.ModifiedDate));
            }
        }

        public IEnumerable<EmailAddress> EmailList(int id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.EmailAddress.Where(em => em.BusinessEntityID == id).ToList();
            }
        }

        public Person GetById(int id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.PersonById(id);
            }
        }

        public int TotalCount()
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.Persons.Count();
            }
        }
    }

    public static class PersonExtensions
    {
        public static IQueryable<Person> CompletePerson(this WebContextDb context)
        {
            return context.Persons
                .Include(p => p.BusinessEntityContact)
                .Include(p => p.EmailAddress)
                .Include(p => p.PersonPhone)                
                .Include(p => p.BusinessEntityID);
        }

        public static Person PersonById(this WebContextDb context, int id)
        {
            return context.Persons
                .Include(p => p.BusinessEntityContact)
                .Include(p => p.EmailAddress)
                .Include(p => p.PersonPhone)                
                .FirstOrDefault(c => c.BusinessEntityID == id);
        }

    }
}
