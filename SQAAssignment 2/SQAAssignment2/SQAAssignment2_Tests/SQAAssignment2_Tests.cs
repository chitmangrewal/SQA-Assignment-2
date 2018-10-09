using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQAAssignment2;
using NUnit.Framework;

namespace SQAAssignment2_Tests
{
    [TestFixture]

    class SQAAssignment2_Tests
    {
        [Test]
        public void side1_input2_side2_input3_expectLenghtEquals2()
        {
            //Arrange
            int side1 = 2;
            int side2 = 3;
            int side3 = 3;
            TriangleSolver testTriangle = new TriangleSolver(side1,side2,side3);

            //Act
            int length = testTriangle.GetLength();
            Assert.AreEqual(length, l);

        }

        [Test]
        public void SetLength_input4_expectLenghtEquals4()
        {
            //Arrange
            int l = 4;
            int w = 5;
            TriangleSolver testRectangle = new TriangleSolver(l, w);

            //Act
            int length = testRectangle.SetLength(4);
            Assert.AreEqual(length, l);

        }

        [Test]
        public void GetWidth_input5_expectWidthEquals5()
        {
            //Arrange
            int l = 3;
            int w = 5;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int width = testRectangle.GetWidth();
            Assert.AreEqual(width, w);

        }

        [Test]
        public void SetWidth_input6_expectWidthEquals3()
        {
            //Arrange
            int l = 6;
            int w = 3;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int width = testRectangle.SetWidth(3);
            Assert.AreEqual(width, w);

        }

        [Test]
        public void GetPerimeter_inputLength1_inputWidth1_expectPerimeterEquals3()
        {
            //Arrange
            int l = 1;
            int w = 1;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int Perimeter = testRectangle.GetPerimeter();
            Assert.AreEqual(Perimeter, 4);

        }

        public void GetArea_inputLength6_inputWidth3_expectAreaEquals18()
        {
            //Arrange
            int l = 6;
            int w = 3;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int Area = testRectangle.GetArea();
            Assert.AreEqual(Area, 18);

        }
    }
}
