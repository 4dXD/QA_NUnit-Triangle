using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace YLee8785Assignment2.Tests
{
    public class TriangleSolverTest
    {

        /// <summary>
        /// Check when input values can not make a trianlge
        /// </summary>
        [Test]
        public void Analyze_WhenInputIs2_3_10_ReturnNotTriangle()
        {
            // Arrange
            uint side1 = 2;
            uint side2 = 3;
            uint side3 = 10;
            string result = "";

            // Act
            result = TriangleSolver.Analyze(side1, side2, side3);

            // Assert
            Assert.AreEqual(result, "Not Triangle", "Radius is not assigned correctly");
        }

        /// <summary>
        /// Check when only one input value is 0
        /// </summary>
        [Test]
        public void Analyze_WhenInputIs0_5_6_ReturnNotTriangle()
        {
            // Arrange
            uint side1 = 0;
            uint side2 = 5;
            uint side3 = 6;
            string result = "";

            // Act
            result = TriangleSolver.Analyze(side1, side2, side3);

            // Assert
            Assert.AreEqual(result, "Not Triangle", "Radius is not assigned correctly");
        }

        /// <summary>
        /// Check when all input values are 0
        /// </summary>
        [Test]
        public void Analyze_WhenInputIs0_0_0_ReturnNotTriangle()
        {
            // Arrange
            uint side1 = 0;
            uint side2 = 0;
            uint side3 = 0;
            string result = "";

            // Act
            result = TriangleSolver.Analyze(side1, side2, side3);

            // Assert
            Assert.AreEqual(result, "Not Triangle", "Radius is not assigned correctly");
        }

        /// <summary>
        /// Check when all input values are same positive number(Equilateral Triangle)
        /// </summary>
        [Test]
        public void Analyze_WhenInputIs5_5_5_ReturnEquilateralTriangle()
        {
            // Arrange
            uint side1 = 5;
            uint side2 = 5;
            uint side3 = 5;
            string result = "";

            // Act
            result = TriangleSolver.Analyze(side1, side2, side3);

            // Assert
            Assert.AreEqual(result, "Equilateral Triangle", "Radius is not assigned correctly");
        }

        /// <summary>
        /// Check when two input values are same(Isosceles Triangle)
        /// </summary>
        [Test]
        public void Analyze_WhenInputIs4_4_5_ReturnIsoscelesTriangle()
        {
            // Arrange
            uint side1 = 4;
            uint side2 = 4;
            uint side3 = 5;
            string result = "";

            // Act
            result = TriangleSolver.Analyze(side1, side2, side3);

            // Assert
            Assert.AreEqual(result, "Isosceles Triangle", "Radius is not assigned correctly");
        }

        /// <summary>
        /// Check when all input values is different positive integer(Scalene Triangle)
        /// </summary>
        [Test]
        public void Analyze_WhenInputIs4_5_6_ReturnScaleneTriangle()
        {
            // Arrange
            uint side1 = 4;
            uint side2 = 5;
            uint side3 = 6;
            string result = "";

            // Act
            result = TriangleSolver.Analyze(side1, side2, side3);

            // Assert
            Assert.AreEqual(result, "Scalene Triangle", "Radius is not assigned correctly");
        }

    }
}
