using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseApp.Domain.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NIP { get; set; }
        public string Regon { get; set; }
        public string CEOName { get; set; }
        public string CEOLastName { get; set; }
        public byte[] LogoPic { get; set; }
        public bool IsActive { get; set; }

        public CustomerContactInformation CustomerContactInformation { get; set; }

        public virtual ICollection<ContactDetail> ContactDetail { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        
    }
}
