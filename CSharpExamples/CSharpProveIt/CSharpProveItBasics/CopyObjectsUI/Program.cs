using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Another option is the IClonable interface

namespace CopyObjectsUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel firstPerson = new PersonModel
            {
                FirstName = "Sue",
                LastName = "Storm",
                DateOfBirth = new DateTime(1998, 7, 19),
                Addresses = new List<AddressModel>
                {
                    new AddressModel
                    {
                        StreetAddress = "101 State Street",
                        City = "Salt Lake City",
                        State = "UT",
                        ZipCode = "76321"
                    },
                    new AddressModel
                    {
                        StreetAddress = "842 Lawrence Way",
                        City = "Jupiter",
                        State = "FL",
                        ZipCode = "22558"
                    }
                }
            };

            // Creates a second PersonModel object
            //PersonModel secondPerson = new PersonModel(firstPerson);
            //PersonModel secondPerson = CopyPerson(firstPerson);
            PersonModel secondPerson = JsonCopy(firstPerson);

            // Set the value of the secondPerson to be a copy of the firstPerson

            // Update the secondPerson's FirstName to "Bob" 
            secondPerson.FirstName = "Bob";

            // and change the Street Address for each of Bob's addresses
            // to a different value
            foreach (var address in secondPerson.Addresses)
            {
                address.StreetAddress = "123 Main Street";
            }

            // Ensure that the following statements are true
            Console.WriteLine($"{ firstPerson.FirstName } != { secondPerson.FirstName }");
            Console.WriteLine($"{ firstPerson.LastName } == { secondPerson.LastName }");
            Console.WriteLine($"{ firstPerson.DateOfBirth.ToShortDateString() } == { secondPerson.DateOfBirth.ToShortDateString() }");
            Console.WriteLine($"{ firstPerson.Addresses[0].StreetAddress } != { secondPerson.Addresses[0].StreetAddress }");
            Console.WriteLine($"{ firstPerson.Addresses[0].City } == { secondPerson.Addresses[0].City }");
            Console.WriteLine($"{ firstPerson.Addresses[1].StreetAddress } != { secondPerson.Addresses[1].StreetAddress }");
            Console.WriteLine($"{ firstPerson.Addresses[1].City } == { secondPerson.Addresses[1].City }");

            Console.ReadLine();
        }

        private static PersonModel JsonCopy(PersonModel source)
        {
            string tempPerson = JsonConvert.SerializeObject(source);
            return JsonConvert.DeserializeObject<PersonModel>(tempPerson);
        }
        
        private static PersonModel CopyPerson(PersonModel source)
        {
            PersonModel output = new PersonModel();

            output.FirstName = source.FirstName;
            output.LastName = source.LastName;
            output.DateOfBirth = source.DateOfBirth;

            foreach (var address in source.Addresses)
            {
                output.Addresses.Add(new AddressModel()
                {
                    StreetAddress = address.StreetAddress,
                    City = address.City,
                    State = address.State,
                    ZipCode = address.ZipCode
                });
            }

            return output;
        }
    }

    public class PersonModel
    {
        public PersonModel()
        {
            
        }

        public PersonModel(PersonModel source)
        {
            FirstName = source.FirstName;
            LastName = source.LastName;
            DateOfBirth = source.DateOfBirth;

            foreach (var address in source.Addresses)
            {
                Addresses.Add(new AddressModel(address));
            }
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<AddressModel> Addresses { get; set; } = new List<AddressModel>();
    }

    public class AddressModel
    {
        public AddressModel()
        {
            
        }
        
        public AddressModel(AddressModel source)
        {
            StreetAddress = source.StreetAddress;
            City = source.City;
            State = source.State;
            ZipCode = source.ZipCode;
        }
        
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
}
