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
    public class StringAssertClassTest : TestBase
    {
        [TestMethod]
        public void ContainsTest()
        {
            string str1 = "Good Morning!";
            string str2 = "ning";

            StringAssert.Contains(str1, str2);
        }

        [TestMethod]
        public void StartsWithTest()
        {
            string str1 = "Good Morning!";
            string str2 = "Go";

            StringAssert.StartsWith(str1, str2);
        }

        [TestMethod]
        public void EndsWithTest()
        {
            string str1 = "Good Morning!";
            string str2 = "!";

            StringAssert.EndsWith(str1, str2);
        }

        [TestMethod]
        public void IsAllLowerCaseTest()
        {
            Regex r = new Regex(@"^([^A-Z])+$");

            StringAssert.Matches("all lower case", r);
        }

        [TestMethod]
        public void IsNotAllLowerCaseTest()
        {
            Regex r = new Regex(@"^([^A-Z])+$");

            StringAssert.DoesNotMatch("All Lower Case", r);
        }
    }
}
