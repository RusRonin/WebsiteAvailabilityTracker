using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WebsiteAvailabilityTracker;

namespace WebsiteAvailabilityTrackerTests
{
    [TestClass]
    public class CompareTests
    {
        [TestMethod]
        public void Compare_nullandnull_0returned()
        {
            int expected = 0;

            Site s1 = null;
            Site s2 = null;
            //т.к. интерфейс требует нестатичный метод, сравнение двух null возможно только от имени третьего объекта
            Site s3 = new Site("https://somesite.ru");

            int actual = s3.Compare(s1, s2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Compare_siteandnull_1returned()
        {
            int expected = 1;

            Site s1 = new Site("https://somesite.ru");
            Site s2 = null;

            int actual = s1.Compare(s1, s2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Compare_nullandsite_minus1returned()
        {
            int expected = -1;

            Site s1 = null;
            Site s2 = new Site("https://somesite.ru");

            int actual = s2.Compare(s1, s2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Compare_siteandsite_1returned()
        {
            int expected = 1;

            Site s1 = new Site("https://somesite.ru");
            Site s2 = new Site("https://anothersite.com");

            int actual = s1.Compare(s1, s2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Compare_siteandsite_0returned()
        {
            int expected = 0;

            Site s1 = new Site("https://somesite.ru");
            Site s2 = new Site("https://somesite.ru");

            int actual = s1.Compare(s1, s2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Compare_siteandsite_minus1returned()
        {
            int expected = -1;

            Site s1 = new Site("https://anothersite.com");
            Site s2 = new Site("https://somesite.ru");

            int actual = s1.Compare(s1, s2);

            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass]
    public class CompareToTests
    {
        [TestMethod]
        public void CompareTo_null_minus1returned()
        {
            int expected = -1;

            Site s1 = new Site("https://somesite.ru");
            Site s2 = null;

            int actual = s1.CompareTo(s2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CompareTo_site_1returned()
        {
            int expected = 1;

            Site s1 = new Site("https://somesite.ru");
            Site s2 = new Site("https://anothersite.com");

            int actual = s1.CompareTo(s2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CompareTo_site_0returned()
        {
            int expected = 0;

            Site s1 = new Site("https://somesite.ru");
            Site s2 = new Site("https://somesite.ru");

            int actual = s1.CompareTo(s2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CompareTo_site_minus1returned()
        {
            int expected = -1;

            Site s1 = new Site("https://anothersite.com");
            Site s2 = new Site("https://somesite.ru");

            int actual = s1.CompareTo(s2);

            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass]
    public class EqualsTests
    {
        [TestMethod]
        public void Equals_nullobject_falsereturned()
        {
            Site s1 = new Site("https://somesite.ru");
            Object obj1 = null;

            Assert.IsFalse(s1.Equals(obj1));
        }

        [TestMethod]
        public void Equals_nullsite_falsereturned()
        {
            Site s1 = new Site("https://somesite.ru");
            Site s2 = null;

            Assert.IsFalse(s1.Equals(s2));
        }

        [TestMethod]
        public void Equals_uncastableobject_falsereturned()
        {
            Site s1 = new Site("https://somesite.ru");
            Object obj1 = new Int32();

            Assert.IsFalse(s1.Equals(obj1));
        }

        [TestMethod]
        public void Equals_castableobject_falsereturned()
        {
            Site s1 = new Site("https://somesite.ru");
            Object obj1 = new Site("https://somesite.com");

            Assert.IsFalse(s1.Equals(obj1));
        }

        [TestMethod]
        public void Equals_castableobject_truereturned()
        {
            Site s1 = new Site("https://somesite.ru");
            Object obj1 = new Site("https://somesite.ru");

            Assert.IsTrue(s1.Equals(obj1));
        }

        [TestMethod]
        public void Equals_site_falsereturned()
        {
            Site s1 = new Site("https://somesite.ru");
            Site s2 = new Site("https://somesite.com");

            Assert.IsFalse(s1.Equals(s2));
        }

        [TestMethod]
        public void Equals_site_truereturned()
        {
            Site s1 = new Site("https://somesite.ru");
            Site s2 = new Site("https://somesite.ru");

            Assert.IsTrue(s1.Equals(s2));
        }
    }
}