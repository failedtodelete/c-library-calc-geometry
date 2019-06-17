using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace unit_tests_c_library_calc_geometry
{
    [TestClass]
    public class AreaCalcTests
    {
        [TestMethod]
        public void CircleA_10_314returned()
        {
            //arrange
            double r = 10;
            double expected = 314.15926535897932;

            //act
            c_library_calc_geometry.AreaCalc c = new c_library_calc_geometry.AreaCalc();
            double actual = c.CircleA(r);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TirangleA_10_15_20_72returned()
        {
            //arrange
            double d = 10;
            double b = 15;
            double c = 20;
            double expected = 72.61843774138906659711122624592;

            //act
            c_library_calc_geometry.AreaCalc x = new c_library_calc_geometry.AreaCalc();
            double actual = x.TriangleA(d, b, c);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
