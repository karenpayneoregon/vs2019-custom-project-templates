using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using ShouldlyUnitTestProject.Base;

namespace ShouldlyUnitTestProject
{
    [TestClass]
    public partial class MainTest : TestBase
    {
        [TestMethod]
        [TestTraits(Trait.Configurations)]
        public void TestMethod1()
        {
            // arrange


            // act


            // assert

        }
        /// <summary>
        /// Simple example using Shouldly 
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.PlaceHolder)]
        public void TestMethod2()
        {
            // arrange
            var monthNames = Enumerable.Range(1, 12)
                .Select((index) => DateTimeFormatInfo.CurrentInfo.GetMonthName(index))
                .ToList();

            /*
             * Various ways to capture output or look at Resharper test sessions
             */
            TestContext.WriteLine(monthNames[0]);
            Console.WriteLine(monthNames[1]);
            Debug.WriteLine(monthNames[2]);

            // act (nothing to do for this test)

            // assert
            monthNames[1].ShouldBe("February");
        }
    }
}
