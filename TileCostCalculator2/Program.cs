using System.Reflection.Metadata;

namespace TileCostCalculator2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const double LABOUR_COST_PER_HOUR = 86.00;      //self explanatory
            const int FLOORING_PER_HOUR = 20;               //average flooring team can only put in 20 square feet of flooring per hour
            double tilesArea = 1;

            Console.WriteLine("++++++++++++++++++++++++++++");
            Console.WriteLine("This is Tile Cost Calculator");
            Console.WriteLine("____________________________");


            Console.WriteLine("In order to calculate are please Choose shape ");
            Console.WriteLine("\t1 - Rectangular Shape");
            Console.WriteLine("\t2 - Non-Rectangular Shape");
            Console.WriteLine("\t3 - Circle");
            Console.WriteLine("\t4 - Triangle ");
            Console.WriteLine("\t5 - Hexagonal ");
            int shape = Convert.ToInt32(Console.ReadLine());

            if (shape == 1)
            {
                Console.Write("Write Width of Area: ");
                double width = Convert.ToDouble(Console.ReadLine());
                Console.Write("Write Length of Area: ");
                double lengthOne = Convert.ToDouble(Console.ReadLine());
                tilesArea = width * lengthOne;
            }
            if (shape == 2)
            {
                Console.Write("Write Length of Area: ");
                double lengthOne = Convert.ToDouble(Console.ReadLine());
                Console.Write("Write 2nd Length of Area: ");
                double width = Convert.ToDouble(Console.ReadLine());
                Console.Write("Write Height of Area: ");
                double height = Convert.ToDouble(Console.ReadLine());
                tilesArea = ((width + lengthOne) * height) / 2;
            }
            if (shape == 3)
            {
                Console.WriteLine("Do you have Radius or Diametre");
                Console.WriteLine("\t1 - Radius");
                Console.WriteLine("\t2 - Diametre ");
                int radiusOrDiametre = Convert.ToInt32(Console.ReadLine());
                double radius = 1;

                if (radiusOrDiametre == 1)                                                      //Calculation of area of Circle with radius
                {
                    Console.Write("Enter Radius : ");
                    radius = Convert.ToDouble(Console.ReadLine());
                }
                if (radiusOrDiametre == 2)                                                      //Calculation of area of Circle with Diametre
                {
                    Console.Write("Enter Diametre : ");
                    double diametre = Convert.ToDouble(Console.ReadLine());
                    radius = diametre / 2;
                }
                tilesArea = Math.PI * (radius * radius);
            }
            if (shape == 4)                                                                     //Triangle
            {
                Console.WriteLine("You have chosen Triangle");
                Console.Write("Write Length of 1st side : ");
                double triangleSideOne = Convert.ToDouble(Console.ReadLine());
                Console.Write("Write Length of 2nd side : ");
                double triangleSideTwo = Convert.ToDouble(Console.ReadLine());
                Console.Write("Write Length of 3rd side : ");
                double triangleSideThree = Convert.ToDouble(Console.ReadLine());
                double triangleSideSumDividedByTwo = (triangleSideOne + triangleSideTwo + triangleSideThree) / 2;
                tilesArea = Math.Sqrt(triangleSideSumDividedByTwo * (triangleSideSumDividedByTwo - triangleSideOne) * (triangleSideSumDividedByTwo - triangleSideTwo) * (triangleSideSumDividedByTwo - triangleSideThree));
            }
            if (shape == 5)
            {
                Console.WriteLine("You have chosen Hexagonal shape");                                     //Hegagonal shape
                Console.Write("Write Length of side : ");
                double hexagonalSide = Convert.ToDouble(Console.ReadLine());
                tilesArea = ((3 * Math.Sqrt(3)) * hexagonalSide * hexagonalSide) / 2;
            }
            if (shape > 0 && shape < 6)
            {
                Console.Write("Write Cost of 1 unit/sq of Tiles:$ ");
                double oneUnitTileCost = Convert.ToDouble(Console.ReadLine());
                double costOfTilesFlooring = tilesArea * oneUnitTileCost;
                Console.WriteLine($"Total Cost to cover area with Tiles :$ {costOfTilesFlooring}");
                double labourCost = tilesArea * (LABOUR_COST_PER_HOUR / FLOORING_PER_HOUR);
                Console.WriteLine($"Labour Cost : $ {labourCost}");
                double costLabourAndTiles = costOfTilesFlooring + labourCost;
                Console.WriteLine($"Total Cost : $ {costLabourAndTiles}");
            }
            else
            {
                Console.WriteLine("Entered data is Invalid");
            }
            Console.WriteLine("Bye");
        }
    }
}

