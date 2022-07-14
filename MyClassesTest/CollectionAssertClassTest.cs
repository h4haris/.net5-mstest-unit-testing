using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses.PersonClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyClassesTest
{
    [TestClass]
    public class CollectionAssertClassTest : TestBase
    {
        [TestMethod]
        [Ignore]
        public void AreCollectionEqual()
        {
            PersonManager mgr = new PersonManager();
            List<Person> peopleExpected = new List<Person>();
            List<Person> peopleActual = new List<Person>();

            peopleExpected.Add(new Person() { FirstName = "Steven", LastName = "Black" });
            peopleExpected.Add(new Person() { FirstName = "John", LastName = "Adam" });
            peopleExpected.Add(new Person() { FirstName = "Paul", LastName = "White" });

            peopleActual = mgr.GetPeople();

            //Note: By default it compares the person objects to see if they are Equal (means exact same object)
            CollectionAssert.AreEqual(peopleExpected, peopleActual);
        }

        [TestMethod]
        public void AreCollectionEqualTest()
        {
            PersonManager mgr = new PersonManager();
            List<Person> peopleExpected;
            List<Person> peopleActual;

            peopleActual = mgr.GetPeople();
            peopleExpected = peopleActual;

            //Note: By default it compares the person objects to see if they are Equal (means exact same object)
            CollectionAssert.AreEqual(peopleExpected, peopleActual);
        }

        [TestMethod]
        public void IsCollectionOfTypeTest()
        {
            PersonManager mgr = new PersonManager();
            List<Person> peopleActual = new List<Person>();

            peopleActual = mgr.GetSupervisors();

            CollectionAssert.AllItemsAreInstancesOfType(peopleActual, typeof(Supervisor));
        }

        [TestMethod]
        public void AreCollectionsEquivalentTest()
        {
            PersonManager mgr = new PersonManager();
            List<Person> peopleExpected = new List<Person>();
            List<Person> peopleActual;

            peopleActual = mgr.GetPeople();

            peopleExpected.Add(peopleActual[1]);
            peopleExpected.Add(peopleActual[2]);
            peopleExpected.Add(peopleActual[0]);

            CollectionAssert.AreEquivalent(peopleExpected, peopleActual);
        }

        [TestMethod]
        public void AreCollectionsEqualWithComparerTest()
        {
            PersonManager mgr = new PersonManager();
            List<Person> peopleExpected = new List<Person>();
            List<Person> peopleActual;

            peopleExpected.Add(new Person() { FirstName = "Steven", LastName = "Black" });
            peopleExpected.Add(new Person() { FirstName = "John", LastName = "Adam" });
            peopleExpected.Add(new Person() { FirstName = "Paul", LastName = "White" });

            peopleActual = mgr.GetPeople();

            //Provide your own "Comparer" to determine equality
            CollectionAssert.AreEqual(peopleExpected, peopleActual, 
                Comparer<Person>.Create((x,y) => 
                x.FirstName == y.FirstName && x.LastName == y.LastName ? 0 : 1));
        }
    }
}
