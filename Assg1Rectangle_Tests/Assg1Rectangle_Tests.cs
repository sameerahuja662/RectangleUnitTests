using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assg1Rectangle;
using NUnit.Framework;

namespace Assg1Rectangle_Tests
{
    [TestFixture]
    class Assg1Rectangle_Tests
    {
        //Test for GetLength() method.
        [Test]
        public void GetLength_input5_expectLengthEquals5() 
        {
            //Arrange
            int l = 5;
            int w = 10;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int length = testRectangle.GetLength();

            //Assert
            Assert.AreEqual(length, l);
        }

        //Test for GetLength() method.
        [Test]
        public void GetLength_input0_expectLengthEquals0()
        {
            //Arrange
            int l = 0;
            int w = 10;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int length = testRectangle.GetLength();

            //Assert
            Assert.AreEqual(length, l);
        }

        //Test for SetLength() method.
        [Test]
        public void SetLength_input10_expectLengthEquals10()
        {
            //Arrange
            int l = 15;
            int w = 5;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int length = testRectangle.SetLength(10);

            //Assert
            Assert.AreEqual(10, length);
        }
        
        //Test for SetLength() method.
        [Test]
        public void SetLength_input0_expectLengthEquals0()
        {
            //Arrange
            int l = 15;
            int w = 5;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int length = testRectangle.SetLength(0);

            //Assert
            Assert.AreEqual(0, length);
        }



        //Test for GetWidth() method.
        [Test]
        public void GetWidth_input5_expectWidthEquals5()
        {
            //Arrange
            int l = 15;
            int w = 5;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int width = testRectangle.GetWidth();

            //Assert
            Assert.AreEqual(width, w);
        }

        //Test for GetWidth() method.
        [Test]
        public void GetWidth_input0_expectWidthEquals0()
        {
            //Arrange
            int l = 15;
            int w = 0;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int width = testRectangle.GetWidth();

            //Assert
            Assert.AreEqual(width, w);
        }



        //Test for SetWidth() method.
        [Test]
        public void SetWidth_input15_expectWidthEquals15()
        {
            //Arrange
            int l = 5;
            int w = 5;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int width = testRectangle.SetWidth(15);

            //Assert
            Assert.AreEqual(15, width);
        }

        //Test for SetWidth() method.
        [Test]
        public void SetWidth_input0_expectWidthEquals0()
        {
            //Arrange
            int l = 5;
            int w = 5;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int width = testRectangle.SetWidth(0);

            //Assert
            Assert.AreEqual(0, width);
        }

        //Test for GetPerimeter() method.
        [Test]
        public void GetPerimeter_input5And10_expectPerimeterEquals30()
        {
            //Arrange
            int l = 5;
            int w = 10;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int perimeter = testRectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(30, perimeter);
        }

        //Test for GetPerimeter() method.
        [Test]
        public void GetPerimeter_input5And0_expectPerimeterEquals10()
        {
            //Arrange
            int l = 5;
            int w = 0;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int perimeter = testRectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(10, perimeter);
        }

        //Test for GetArea() method.
        [Test]
        public void GetArea_input5And5_expectAreaEquals25()
        {
            //Arrange
            int l = 5;
            int w = 5;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int area = testRectangle.GetArea();

            //Assert
            Assert.AreEqual(25, area);
        }

        //Test for GetArea() method.
        [Test]
        public void GetArea_input5And0_expectAreaEquals0()
        {
            //Arrange
            int l = 5;
            int w = 0;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int area = testRectangle.GetArea();

            //Assert
            Assert.AreEqual(0, area);
        }
    }
}
