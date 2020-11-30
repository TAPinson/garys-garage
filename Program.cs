using System;

namespace garage
{
    class Program
    {
        static void Main(string[] args)
        {
            static void spacer()
            {
                Console.WriteLine(" ");
            }

            Cessna myCessna = new Cessna()
            {
                MainColor = "blue",
                MaximumOccupancy = 3
            };

            Ram myRam = new Ram()
            {
                MainColor = "Yellow",
                MaximumOccupancy = 3
            };

            Tesla myTesla = new Tesla()
            {
                MainColor = "Black",
                MaximumOccupancy = 4
            };

            Zero myZero = new Zero()
            {
                MainColor = "Silver",
                MaximumOccupancy = 2
            };

            myCessna.Drive();
            myCessna.Turn("left");
            myCessna.Stop();
            spacer();
            myRam.Drive();
            myRam.Turn("right");
            myRam.Stop();
            spacer();
            myTesla.Drive();
            myTesla.Turn("right");
            myTesla.Stop();
            spacer();
            myZero.Drive();
            myZero.Turn("left");
            myZero.Stop();

        }
    }
}
