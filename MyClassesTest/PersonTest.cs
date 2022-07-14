using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses.PersonClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassesTest
{
    [TestClass]
    public class PersonTest : TestBase
    {
        [TestMethod]
        public void IsInstanceOfTypeTest()
        {
            PersonManager mgr = new PersonManager();
            Person person;

            person = mgr.CreatePerson("Paul", "Sheriff", true);

            Assert.IsInstanceOfType(person, typeof(Supervisor));
            Assert.IsInstanceOfType(person, typeof(Person));
        }

        [TestMethod]
        public void IsNullTest()
        {
            PersonManager mgr = new PersonManager();
            Person person;

            person = mgr.CreatePerson("", "Sheriff", true);


            Assert.IsNull(person);
        }
    }
}
