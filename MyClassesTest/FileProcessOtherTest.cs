using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses;
using System;
using System.IO;

namespace MyClassesTest
{
    [TestClass]
    public class FileProcessOtherTest : TestBase
    {
        #region Class Initialize and Cleanup Methods
        [ClassInitialize()]
        public static void ClassInitialize(TestContext tc)
        {
            // TODO: Initialize for all tests in class
            tc.WriteLine("In ClassInitialize() method");
        }

        [ClassCleanup()]
        public static void ClassCleanup()
        {
            // TODO: Clean up after all
            // tests in class
        }
        #endregion

        #region TestInitialize Method
        [TestInitialize]
        public void TestInitialize()
        {
            TestContext.WriteLine("In TestInitialize() method");
            WriteDescription(this.GetType());

            if (TestContext.TestName.StartsWith("FileNameDoesExist"))
            {
                SetGoodFileName();
                if (!string.IsNullOrEmpty(_GoodFileName))
                {
                    TestContext.WriteLine("Creating file: " + _GoodFileName);
                    // Create the 'Good' file.
                    File.AppendAllText(_GoodFileName, "Some Text");
                }
            }
        }
        #endregion

        #region TestCleanup Method
        [TestCleanup]
        public void TestCleanup()
        {
            TestContext.WriteLine("In TestCleanup() method");

            if (TestContext.TestName.StartsWith("FileNameDoesExist"))
            {
                // Delete file
                if (File.Exists(_GoodFileName))
                {
                    TestContext.WriteLine("Deleting file: " + _GoodFileName);
                    File.Delete(_GoodFileName);
                }
            }
        }
        #endregion

        [TestMethod]
        [Ignore]
        public void FileNameDoesExistSimpleMessage()
        {
            FileProcess fp = new FileProcess();
            bool fromCall;

            TestContext.WriteLine(@"Checking File " + _GoodFileName);

            fromCall = fp.FileExists(_GoodFileName);

            //Assert.IsFalse(fromCall, $"File {_GoodFileName} Does Not Exist.");
            Assert.IsFalse(fromCall, "File {0} Does Not Exist.", _GoodFileName);
        }

        [TestMethod]
        public void AreEqualCaseSensitiveTest()
        {
            string str1 = "Alex";
            string str2 = "Alex";

            Assert.AreEqual(str1, str2);
        }

        [TestMethod]
        public void AreEqualCaseInsensitiveTest()
        {
            string str1 = "Alex";
            string str2 = "alex";

            Assert.AreEqual(str1, str2, true);
        }

        [TestMethod]
        public void AreNotEqualTest()
        {
            string str1 = "Alex";
            string str2 = "John";

            Assert.AreNotEqual(str1, str2);
        }

        [TestMethod]
        public void AreNotSameTest()
        {
            FileProcess x = new FileProcess();
            FileProcess y = new FileProcess();

            Assert.AreNotSame(x, y);
        }

        [TestMethod]
        public void AreSameTest()
        {
            FileProcess x = new FileProcess();
            FileProcess y = x;

            Assert.AreSame(x, y);
        }
    }
}
