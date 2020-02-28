using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YLee8785Assignment2
{
    public static class TriangleSolver
    {
        enum TriangleType{
            Scalene,
            Equilateral,
            Isosceles
        }

        /// <summary>
        /// Analyze three input numbers.
        /// Check the input values are able to make a triangle
        /// and retrun the Type of the triangle.
        /// </summary>
        /// <param name="firstSide">the first Side of a Triangle</param>
        /// <param name="secondSide">the Second Side of a Triangle</param>
        /// <param name="lastSide">first Side of a Triangle</param>
        /// <returns>Type of the Triangle(Scalene, Equilateral, Isosceles)</returns>
        public static string Analyze(uint firstSide, uint secondSide, uint lastSide)
        {
            uint[] triangle = { firstSide, secondSide, lastSide };
            Array.Sort(triangle);
            
            //triangle[0]+triangle[1] <= triangle[2]
            if (triangle[0] <= triangle[2]-triangle[1])
            {
                return "Not Triangle";
            }

            string triangleType = "";

            if(firstSide == secondSide && secondSide == lastSide)
            {
                triangleType = TriangleType.Equilateral.ToString();
            }
            else if (firstSide == secondSide || secondSide == lastSide || lastSide == firstSide)
            {
                triangleType = TriangleType.Isosceles.ToString();
            }
            else
            {
                triangleType = TriangleType.Scalene.ToString();
            }

            return triangleType + " Triangle";
        }

    }
}
