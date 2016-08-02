using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;
using WebDeveloper.Model.DTO;

namespace WebDeveloper.DataAccess
{
    public class AddressRepository : BaseDataAccess<Address>
    {
        public List<AddressModelView> GetListDto()
        {
            using (var db =new WebContextDb())
            {
                return Automapper.GetGeneric<List<Address>,
                                             List<AddressModelView>>(
                                            db.Address.Take(10).ToList()
                                            );
            }
        }
    }
}
