using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DemoMarch15;

namespace marchDemo15.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public static void Add_Simple_Expected()
        {
            // comment
            Program p1 = new Program();
            Assert.AreEqual(5, p1.Add(2,3));


        }
        public static void Add_Simple_Expected_2()
        {
            // comment
            Program p1 = new Program();
            Assert.AreEqual(5, p1.Add(2, 3));


        }
    }
}
