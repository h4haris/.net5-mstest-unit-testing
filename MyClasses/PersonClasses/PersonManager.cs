using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses.PersonClasses
{
    public class PersonManager
    {
        public Person CreatePerson(string firstName, string LastName, bool isSupervisor)
        {
            Person person = null;

            if (!string.IsNullOrEmpty(firstName))
            {
                if(isSupervisor)
                    person = new Supervisor();
                else
                    person = new Employee();

                person.FirstName = firstName;
                person.LastName = LastName;
            }

            return person;
        }

        /// <summary>
        /// This method simulates retrieving a list of Person object
        /// </summary>
        /// <returns>A collection of Person objects</returns>
        public List<Person> GetPeople()
        {
            List<Person> people = new List<Person>();

            people.Add(new Person() { FirstName = "Steven", LastName= "Black"});
            people.Add(new Person() { FirstName = "John", LastName= "Adam"});
            people.Add(new Person() { FirstName = "Paul", LastName= "White"});

            return people;
        }

        /// <summary>
        /// This method simulates retrieving a list of Supervisor object
        /// </summary>
        /// <returns>A collection of Supervisor objects</returns>
        public List<Person> GetSupervisors()
        {
            List<Person> people = new List<Person>();

            people.Add(CreatePerson("Jacob","Stew", true));
            people.Add(CreatePerson("Michael","Sheriff", true));

            return people;
        }

        /// <summary>
        /// This method simulates retrieving a list of Employee object
        /// </summary>
        /// <returns>A collection of Employee objects</returns>
        public List<Person> GetEmployees()
        {
            List<Person> people = new List<Person>();

            people.Add(CreatePerson("Miranda", "White", false));
            people.Add(CreatePerson("Alex", "Black", false));

            return people;
        }

        /// <summary>
        /// This method simulates retrieving a list of Supervisor and Employee object
        /// </summary>
        /// <returns>A collection of Supervisor and Employee objects</returns>
        public List<Person> GetSupervisorsAndEmployee()
        {
            List<Person> people = new List<Person>();

            people.AddRange(GetEmployees());
            people.AddRange(GetSupervisors());

            return people;
        }
    }
}
