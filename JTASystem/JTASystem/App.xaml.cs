using JTASystem.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace JTASystem
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
          
           /* var activeUserStatus = new Status();
            activeUserStatus.Name = "Active";
            activeUserStatus.Type = "Person";
            activeUserStatus.Color = "Green";
            activeUserStatus.Id = 1;

            var activeAddressStatus = new Status();
            activeAddressStatus.Name = "Active";
            activeAddressStatus.Type = "Address";
            activeAddressStatus.Color = "Green";
            activeAddressStatus.Id = 2;

            var quezonRoute = new Route();
            quezonRoute.Name = "Quezon";
            quezonRoute.Id = 1;
                 
                 

            var employeeCategory = new Category();
            employeeCategory.Name = "Employee";
            employeeCategory.Type = "Person";
            employeeCategory.Color = "Blue";
            employeeCategory.Id = 5;


            var emailContactInfo = new ContactInfo();
            emailContactInfo.ContactPerson = "Jeery Tan";
            emailContactInfo.Contact = "jerry_ayson61@yahoo.com";
            emailContactInfo.Type = ContactType.Email;
            emailContactInfo.Status = activeAddressStatus;


            var address1 = new Address();
            address1.Address = "#23 Samat St. Cor. Banawe";
            address1.City = "Malabon City";
            address1.Route = quezonRoute;
            address1.Status = activeAddressStatus;


            var person = new Person();
            person.Category = employeeCategory;
            person.Name = "Herry Hello";
            person.AddAddress(address1);
            person.AddContact(emailContactInfo);


            using (var session = NHibernateSession.SessionFactory.OpenSession())
            using(var transaction = session.BeginTransaction())
            {
                session.Save(person);

                foreach (var address in person.Addresses)
                {
                    session.Save(address);
                }

                foreach (var contact in person.ContactInformations)
                {
                    session.Save(contact);
                }

                transaction.Commit();

            }

            Console.ReadLine();*/

        }
    }
}
