using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDeveloper.Model
{
    

    [Table("Person.BusinessEntity")]
    public partial class BusinessEntity
    {
        
        public BusinessEntity()
        {
            BusinessEntityAddress = new HashSet<BusinessEntityAddress>();
            BusinessEntityContact = new HashSet<BusinessEntityContact>();
        }

        public int BusinessEntityID { get; set; }

        public Guid rowguid { get; set; }

        public DateTime ModifiedDate { get; set; }

        [JsonProperty]
        public virtual ICollection<BusinessEntityAddress> BusinessEntityAddress { get; set; }
        [JsonProperty]
        public virtual ICollection<BusinessEntityContact> BusinessEntityContact { get; set; }
        [JsonIgnore]
        public virtual Person Person { get; set; }
    }
}
