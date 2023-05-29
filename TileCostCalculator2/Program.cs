namespace TileCostCalculator2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width;                           //Width of rectangular shape
            double length;                          //Length of rectangular shape
            double height;                          //height of rectangular shape
            double tilesArea;                       //area of tiles in sq feet
            double oneUnitTileCost;                 //Cost of 1sq foot of Tile
            double costOfTilesFlooring;             //Cost of Tiles to cover area
            double labourCost;                      //labor cost to do flooring with tiles
            double labourCostPerHour = 86.00;       //self explanatory
            int flooringPerHour = 20;               //average flooring team can only put in 20 square feet of flooring per hour
            int radiusOrDiametre;                   //radius or diametre variable
            double radius;                          //circle radius
            double diametre;                        //circle diametre
            double costLabourAndTiles;              //labor and tiles sum cost



            Console.WriteLine("++++++++++++++++++++++++++++");
            Console.WriteLine("This is Tile Cost Calculator");
            Console.WriteLine("____________________________");

            Console.WriteLine("In order to calculate are please Choose shape ");
            Console.WriteLine("\t1 - Rectangular Shape");
            Console.WriteLine("\t2 - Non-Rectangular Shape ");
            Console.WriteLine("\t3 - Pick One additional shape ");
            int shape = Convert.ToInt32(Console.ReadLine());

            if (shape == 1)                                                                            //Rectangle
            {
                Console.Write("Write Width of Area: ");
                width = Convert.ToDouble(Console.ReadLine());
                Console.Write("Write Length of Area: ");
                length = Convert.ToDouble(Console.ReadLine());
                Console.Write("Write Cost of 1 unit of Tiles:$ ");
                oneUnitTileCost = Convert.ToDouble(Console.ReadLine());
                tilesArea = width * length;
                costOfTilesFlooring = tilesArea * oneUnitTileCost;
                Console.WriteLine("Cost of Tiles to cover area " + (width * length));
                Console.WriteLine($"Total Cost to cover area with Tiles :$ {costOfTilesFlooring}");
                labourCost = tilesArea * (labourCostPerHour / flooringPerHour);
                Console.WriteLine($"Labour Cost : $ {labourCost}");
                costLabourAndTiles = costOfTilesFlooring + labourCost;
                Console.WriteLine($"\tTotal Cost : $ {costLabourAndTiles}");
            }
            if (shape == 2)                                                                          //Non Rectangle
            {
                Console.Write("Write 1st Length of Area: ");
                width = Convert.ToDouble(Console.ReadLine());
                Console.Write("Write 2nd Length of Area: ");
                length = Convert.ToDouble(Console.ReadLine());
                Console.Write("Write Height of Area: ");
                height = Convert.ToDouble(Console.ReadLine());
                Console.Write("Write Cost of 1 unit of Tiles:$ ");
                oneUnitTileCost = Convert.ToDouble(Console.ReadLine());
                tilesArea = (width + length) * height;
                costOfTilesFlooring = (tilesArea * oneUnitTileCost) / 2;
                Console.WriteLine($"Total Cost to cover area with Tiles :$ {costOfTilesFlooring}");
                labourCost = tilesArea * (labourCostPerHour / flooringPerHour);
                Console.WriteLine($"Labour Cost : $ {labourCost}");
                costLabourAndTiles = costOfTilesFlooring + labourCost;
                Console.WriteLine($"\tTotal Cost : $ {costLabourAndTiles}");

            }
            if (shape == 3)                                                                         //Additional Shape
            {
                Console.WriteLine("Choose additional shape to Calculate area");
                Console.WriteLine("\t1 - Circle");
                Console.WriteLine("\t2 - Triangle ");
                Console.WriteLine("\t3 - Hexagonal ");
                int additionalShape = Convert.ToInt32(Console.ReadLine());

                if (additionalShape == 1)                                                           //Circle
                {
                    Console.WriteLine("Do you have Radius or Diametre");
                    Console.WriteLine("\t1 - Radius");
                    Console.WriteLine("\t2 - Diametre ");
                    radiusOrDiametre = Convert.ToInt32(Console.ReadLine());

                    if (radiusOrDiametre == 1)                                                      //Calculation of area of Circle with radius
                    {
                        Console.Write("Enter Radius");
                        radius = Convert.ToDouble(Console.ReadLine());
                        tilesArea = 3.14 * (radius * radius);
                        Console.Write("Write Cost of 1 unit of Tiles:$ ");
                        oneUnitTileCost = Convert.ToDouble(Console.ReadLine());
                        costOfTilesFlooring = tilesArea * oneUnitTileCost;
                        Console.WriteLine($"Total Cost to cover area with Tiles :$ {costOfTilesFlooring}");
                        labourCost = tilesArea * (labourCostPerHour / flooringPerHour);
                        Console.WriteLine($"Labour Cost : $ {labourCost}");
                        costLabourAndTiles = costOfTilesFlooring + labourCost;
                        Console.WriteLine($"Total Cost : $ {costLabourAndTiles}");
                    }
                    if (radiusOrDiametre == 2)                                                      //Calculation of area of Circle with Diametre
                    {
                        Console.Write("Enter Diametre");
                        diametre = Convert.ToDouble(Console.ReadLine());
                        tilesArea = 3.14 * ((diametre / 2) * (diametre / 2));
                        Console.Write("Write Cost of 1 unit of Tiles:$ ");
                        oneUnitTileCost = Convert.ToDouble(Console.ReadLine());
                        costOfTilesFlooring = tilesArea * oneUnitTileCost;
                        Console.WriteLine($"Total Cost to cover area with Tiles :$ {costOfTilesFlooring}");
                        labourCost = tilesArea * (labourCostPerHour / flooringPerHour);
                        Console.WriteLine($"Labour Cost : $ {labourCost}");
                        costLabourAndTiles = costOfTilesFlooring + labourCost;
                        Console.WriteLine($"Total Cost : $ {costLabourAndTiles}");
                    }
                }
                if (additionalShape == 2)                                                             //Triangle
                {
                    Console.WriteLine("You have chosen Triangle");
                    Console.Write("Write Length of 1st side : ");
                    double triangleSideOne = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Write Length of 2nd side : ");
                    double triangleSideTwo = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Write Length of 3rd side : ");
                    double triangleSideThree = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Write Cost of 1 unit of Tiles:$ ");
                    oneUnitTileCost = Convert.ToDouble(Console.ReadLine());
                    double triangleSideSumDividedByTwo = (triangleSideOne + triangleSideTwo + triangleSideThree) / 2;
                    tilesArea = Math.Sqrt(triangleSideSumDividedByTwo * (triangleSideSumDividedByTwo - triangleSideOne) * (triangleSideSumDividedByTwo - triangleSideTwo) * (triangleSideSumDividedByTwo - triangleSideThree));
                    costOfTilesFlooring = tilesArea * oneUnitTileCost;
                    Console.WriteLine($"Total Cost to cover area with Tiles :$ {costOfTilesFlooring}");
                    labourCost = tilesArea * (labourCostPerHour / flooringPerHour);
                    Console.WriteLine($"Labour Cost : $ {labourCost}");
                    costLabourAndTiles = costOfTilesFlooring + labourCost;
                    Console.WriteLine($"Total Cost : $ {costLabourAndTiles}");
                }
                if (additionalShape == 3)
                {
                    Console.WriteLine("You have chosen Hexagonal shape");                                     //Hegagonal shape
                    Console.Write("Write Length of side : ");
                    double hexagonalSide = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Write Cost of 1 unit of Tiles:$ ");
                    oneUnitTileCost = Convert.ToDouble(Console.ReadLine());
                    tilesArea = ((3 * Math.Sqrt(3)) * hexagonalSide * hexagonalSide) / 2;
                    costOfTilesFlooring = tilesArea * oneUnitTileCost;
                    Console.WriteLine($"Total Cost to cover area with Tiles :$ {costOfTilesFlooring}");
                    labourCost = tilesArea * (labourCostPerHour / flooringPerHour);
                    Console.WriteLine($"Labour Cost : $ {labourCost}");
                    costLabourAndTiles = costOfTilesFlooring + labourCost;
                    Console.WriteLine($"Total Cost : $ {costLabourAndTiles}");
                }
            }
        }
    }
}
