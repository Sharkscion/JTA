using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTASystem.Models
{
    class Person
    {
        public virtual string Name { get; set; }
        public virtual Category Category  { get; set; }
        public virtual int Id { get; set; }

        public virtual ISet<Address> Addresses { get; set;}
        public virtual ISet<ContactInfo> ContactInformations { get; set; }


        public Person()
        {
            Addresses = new HashSet<Address>();
            ContactInformations = new HashSet<ContactInfo>();
        }

        public virtual void AddAddress(Address address)
        {
            address.Person = this;
            Addresses.Add(address);
        }

        public virtual void AddContact(ContactInfo contact)
        {
            contact.Person = this;
            ContactInformations.Add(contact);
        }

    }
}
